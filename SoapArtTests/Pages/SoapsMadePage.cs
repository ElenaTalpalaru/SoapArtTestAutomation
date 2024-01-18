using EsFramework.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsTests.Pages
{
    public class SoapsMadePage : BasePage
    {
        public SoapsMadePage(IDriverFixture driverFixture) : base(driverFixture)
        {
        }

        private IWebElement linkChristmassSoap => _driverFixture.Driver.FindElement(By.LinkText("Christmas Soap"));

        public void ClickSoapLink() => linkChristmassSoap.Click();
    }
}
