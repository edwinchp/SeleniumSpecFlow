using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSpecFlow.Drivers
{
    internal class ChromeDriverFactory : IWebDriverFactory
    {
        public IWebDriver CreateWebDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            return new ChromeDriver(chromeOptions);
        }
    }
}
