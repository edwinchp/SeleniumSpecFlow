using OpenQA.Selenium;

namespace SeleniumSpecFlow.Pages
{
    internal class Page
    {
        private readonly IWebDriver _driver;

        public Page(IWebDriver driver)
        {
            _driver = driver;
        }

        protected void Type(By ele, string text)
        {
            _driver.FindElement(ele).SendKeys(text);
        }

        protected void Clear(By ele)
        {
            _driver.FindElement(ele).Clear();
        }

        protected string GetTitle()
        {
            return _driver.Title;
        }

        protected void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
