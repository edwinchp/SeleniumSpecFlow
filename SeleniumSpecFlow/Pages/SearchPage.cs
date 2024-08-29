using OpenQA.Selenium;

namespace SeleniumSpecFlow.Pages
{
    internal class SearchPage : Page
    {
        public SearchPage(IWebDriver driver) : base(driver) { }

        private readonly By _searchBox = By.XPath("//input[@id='search']");

        internal void GoToLandingPage()
        {
            GoToUrl("https://youtube.com");
        }

        internal void SearchVideo(string text)
        {
            Type(_searchBox, text);
            Type(_searchBox, Keys.Enter);
        }

        internal void ClearSearchBox()
        {
            Clear(_searchBox);
        }
    }
}
