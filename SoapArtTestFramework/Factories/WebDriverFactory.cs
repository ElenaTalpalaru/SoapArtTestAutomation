using EsFramework.Drivers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace EsFramework.Factories
{
    internal class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                _ => new ChromeDriver()
            };
        }
    }
}
