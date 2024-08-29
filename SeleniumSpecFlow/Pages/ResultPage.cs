using OpenQA.Selenium;

namespace SeleniumSpecFlow.Pages
{
    internal class ResultPage
    {
        private IWebDriver _driver;
        public ResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal string GetTitle()
        {
            return _driver.Title;
        }
    }
}
