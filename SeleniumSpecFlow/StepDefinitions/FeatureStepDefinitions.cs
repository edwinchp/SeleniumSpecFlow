using OpenQA.Selenium;
using SeleniumSpecFlow.Pages;
using TechTalk.SpecFlow.Assist;

namespace SeleniumSpecFlow.StepDefinitions
{
    [Binding]
    internal sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;
        private SearchPage searchPage;
        private ResultPage resultPage;

        public FeatureStepDefinitions(IWebDriver driver) 
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Navigate().GoToUrl("https://youtube.com");
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            searchPage = new SearchPage(driver);
            resultPage = searchPage.SearchText("Testers Talk");
            Thread.Sleep(3000);
        }

        [Then(@"Search for the Testers Talk in a wrong Xpath")]
        public void ThenSearchForTheTestersTalkInAWrongXpath()
        {
            driver.FindElement(By.XPath("//input[@id='search-invalid']")).SendKeys("Testers Talk");
            driver.FindElement(By.XPath("//input[@id='search-invalid']")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        [Then(@"Search for the (.*) text")]
        public void ThenSearchFor(string searchText)
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(searchText);
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        [Then(@"Search for the following")]
        [When(@"Search for the following")]
        public void ThenSearchForTheFollowing(Table table)
        {
            var searchCriteria = table.CreateSet<SearchTextTestData>();

            searchCriteria.ToList().ForEach(searchText =>
            {
                driver.FindElement(By.XPath("//input[@id='search']")).Clear();
                driver.FindElement(By.XPath("//input[@id='search3']")).SendKeys(searchText.searchText);
                driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
                Thread.Sleep(4000);
            });
        }

        [Then(@"Validate the title contains ""([^""]*)""")]
        public void ThenValidateTheTitleContains(string text)
        {
            resultPage.GetTitle().Should().Contain(text);
        }

    }

    public class SearchTextTestData
    {
        public string searchText { get; set; }
    }
}