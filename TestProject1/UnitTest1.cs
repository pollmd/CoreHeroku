using OpenQA.Selenium.Chrome;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithChromeDriver()
        {
            var driver = new ChromeDriver("C:/WebDriver");

            driver.Navigate().GoToUrl("https://poll.md/");
            //driver.Navigate().GoToUrl("https://localhost:5001/");

            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            //{
            //    //driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
            //    //var link = driver.FindElement(By.PartialLinkText("TFS Test API"));
            //    //var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
            //    //((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
            //    //var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            //    //var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("TFS Test API")));
            //    //clickableElement.Click();
            //}
        }
    }
}
