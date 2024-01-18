using EsFramework.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsTests.Pages
{
    public abstract class BasePage
    {
        public readonly IDriverFixture _driverFixture;

        public BasePage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        //private IWebElement linkPage(string lnkText) => _driverFixture.Driver.FindElement(By.LinkText(lnkText));
       // private IWebElement linkSoapsThatIMade => _driverFixture.Driver.FindElement(By.LinkText($"Soaps that I made"));
        //private IWebElement linkDoItYourself => _driverFixture.Driver.FindElement(By.LinkText("Do it yourself"));
        //private IWebElement linkForTesting => _driverFixture.Driver.FindElement(By.LinkText("For testing"));
        //private IWebElement linkContact => _driverFixture.Driver.FindElement(By.LinkText("Contact me"));

       // public void ClickLinkPage(string PageName) => linkPage(PageName);
    }
}
