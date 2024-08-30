using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumSpecFlow.Drivers
{
    internal class EdgeDriverFactory : IWebDriverFactory
    {
        public IWebDriver CreateWebDriver()
        {
            return new EdgeDriver();
        }
    }
}
