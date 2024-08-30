namespace SeleniumSpecFlow.Drivers
{
    internal class WebDriverCreator
    {
        public static IWebDriverFactory CreateWebDriver(string browser)
        {
            return browser switch
            {
                "chrome" => new ChromeDriverFactory(),
                "edge" => new EdgeDriverFactory(),
                _ => new ChromeDriverFactory(),
            };
        }
    }
}