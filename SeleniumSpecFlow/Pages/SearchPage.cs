using OpenQA.Selenium;

namespace SeleniumSpecFlow.Pages
{
    internal class SearchPage
    {
        private IWebDriver _driver;
        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal ResultPage SearchText(string text)
        {
            _driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(text);
            _driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            return new ResultPage(_driver);
        }
    }
}
