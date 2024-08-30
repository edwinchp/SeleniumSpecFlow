using OpenQA.Selenium;

namespace SeleniumSpecFlow.Drivers
{
    internal interface IWebDriverFactory
    {
        public IWebDriver CreateWebDriver();
    }
}
