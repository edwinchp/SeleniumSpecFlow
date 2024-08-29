using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSpecFlow.StepDefinitions
{
    [Binding]
    internal sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://youtube.com";
            Thread.Sleep(5000);
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.Name("search_query")).SendKeys("Testers Talk" + Keys.Enter);
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
