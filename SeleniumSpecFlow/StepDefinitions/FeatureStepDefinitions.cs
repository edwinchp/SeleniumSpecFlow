using OpenQA.Selenium;
using SeleniumSpecFlow.Pages;
using TechTalk.SpecFlow.Assist;

namespace SeleniumSpecFlow.StepDefinitions
{
    [Binding]
    internal sealed class FeatureStepDefinitions
    {
        private readonly SearchPage searchPage;
        private readonly ResultPage resultPage;

        public FeatureStepDefinitions(IWebDriver driver) 
        {
            searchPage = new SearchPage(driver);
            resultPage = new ResultPage(driver);
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            searchPage.GoToLandingPage();
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            searchPage.SearchVideo("Testers Talk");
            Thread.Sleep(3000);
        }

        [Then(@"Search for the Testers Talk in a wrong Xpath")]
        public void ThenSearchForTheTestersTalkInAWrongXpath()
        {
            throw new Exception();
        }

        [Then(@"Search for the (.*) text")]
        public void ThenSearchFor(string searchText)
        {
            searchPage.SearchVideo(searchText);
            Thread.Sleep(1000);
        }

        [Then(@"Search for the following")]
        [When(@"Search for the following")]
        public void ThenSearchForTheFollowing(Table table)
        {
            var searchCriteria = table.CreateSet<SearchTextTestData>();

            searchCriteria.ToList().ForEach(searchText =>
            {
                searchPage.ClearSearchBox();
                searchPage.SearchVideo(searchText.searchText);
                Thread.Sleep(4000);
            });
        }

        [Then(@"Validate the title contains ""([^""]*)""")]
        public void ThenValidateTheTitleContains(string text)
        {
            resultPage.GetPageTitle().Should().Contain(text);
        }

    }

    public class SearchTextTestData
    {
        public string searchText { get; set; }
    }
}