using EsFramework.Drivers;
using OpenQA.Selenium;

namespace EsTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IDriverFixture driverFixture) : base(driverFixture)
        {
           
        }

        private IWebElement linkHome => _driverFixture.Driver.FindElement(By.LinkText("Home"));
        private IWebElement linkSoapsThatIMade => _driverFixture.Driver.FindElement(By.LinkText($"Soaps that I made"));
        private IWebElement linkDoItYourself => _driverFixture.Driver.FindElement(By.LinkText("Do it yourself"));
        private IWebElement linkForTesting => _driverFixture.Driver.FindElement(By.LinkText("For testing"));
        private IWebElement linkContact => _driverFixture.Driver.FindElement(By.LinkText("Contact me"));

        public void ClickLinkHome() => linkHome.Click();
        public void ClickSoapsThatIMade() => linkSoapsThatIMade.Click();
        public void ClickLinkForTesting() => linkForTesting.Click();
    }
}
