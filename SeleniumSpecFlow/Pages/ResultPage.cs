using OpenQA.Selenium;

namespace SeleniumSpecFlow.Pages
{
    internal class ResultPage : Page
    {
        public ResultPage(IWebDriver driver) : base(driver) { }

        internal string GetPageTitle()
        {
            return GetTitle();
        }
    }
}
