using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreHeroku.Data;
using CoreHeroku.Model;

namespace CoreHeroku.Controllers
{
    public class PersoanasController : Controller
    {
        private readonly CoreHerokuContext _context;

        public PersoanasController(CoreHerokuContext context)
        {
            _context = context;
        }

        // GET: Persoanas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Person.ToListAsync());
        }

        // GET: Persoanas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persoana = await _context.Person
                .FirstOrDefaultAsync(m => m.id == id);
            if (persoana == null)
            {
                return NotFound();
            }

            return View(persoana);
        }

        // GET: Persoanas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Persoanas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name")] Persoana persoana)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persoana);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persoana);
        }

        // GET: Persoanas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persoana = await _context.Person.FindAsync(id);
            if (persoana == null)
            {
                return NotFound();
            }
            return View(persoana);
        }

        // POST: Persoanas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name")] Persoana persoana)
        {
            if (id != persoana.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persoana);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersoanaExists(persoana.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(persoana);
        }

        // GET: Persoanas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persoana = await _context.Person
                .FirstOrDefaultAsync(m => m.id == id);
            if (persoana == null)
            {
                return NotFound();
            }

            return View(persoana);
        }

        // POST: Persoanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persoana = await _context.Person.FindAsync(id);
            _context.Person.Remove(persoana);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersoanaExists(int id)
        {
            return _context.Person.Any(e => e.id == id);
        }
    }
}
