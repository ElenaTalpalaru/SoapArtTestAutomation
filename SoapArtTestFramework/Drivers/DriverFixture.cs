using EsFramework.Config;
using EsFramework.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EsFramework.Drivers
{
    public class DriverFixture : IDriverFixture, IDisposable
    {
        private readonly TestSettings _testSettings;

        public IWebDriver Driver { get; }

        public DriverFixture(BrowserType browserType)
        {
            _testSettings = InitiateTestSettings(browserType);
            Driver = WebDriverFactory.GetWebDriver(_testSettings.BrowserType); 
            Driver.Navigate().GoToUrl(_testSettings.AppUrl);
        }

        private TestSettings InitiateTestSettings(BrowserType browserType)
        {
            var testSetting = new TestSettings()
            {
                BrowserType = browserType,
                AppUrl = new Uri("https://elenatalpalaru.github.io/soap-art/"),
                TimeoutInterval = 30
            };

            return testSetting;
        }



        public void Dispose()
        {
            Driver.Quit();
        }
    }

    public enum BrowserType
    {
        Chrome,
        Firefox,
        Safari
    }
}


