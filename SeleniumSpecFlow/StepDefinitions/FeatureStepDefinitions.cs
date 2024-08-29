﻿using OpenQA.Selenium;

namespace SeleniumSpecFlow.StepDefinitions
{
    [Binding]
    internal sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;

        public FeatureStepDefinitions(IWebDriver driver) 
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://youtube.com";
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.XPath("//input[@id='sear1ch']")).SendKeys("Testers Talk");
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
        }
    }
}