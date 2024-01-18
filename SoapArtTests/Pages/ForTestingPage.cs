using EsFramework.Drivers;
using EsFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsTests.Pages
{
    public class ForTestingPage : BasePage
    {
        public ForTestingPage(IDriverFixture driverFixture) : base(driverFixture)
        {
        }

        //Boundary value area

        private IWebElement usernameField => _driverFixture.Driver.FindElement(By.Id("username"));
        private IWebElement passwordField => _driverFixture.Driver.FindElement(By.Id("password"));
        private IWebElement submitBtn => _driverFixture.Driver.FindElement(By.Id("submit"));

        public void ClickSubmitButton() => submitBtn.Click();

        public ForTestingPage FillInBoundaryValueForm(string username, string password)
        {
            usernameField.ClearAndEnterText(username);
            passwordField.ClearAndEnterText(password);
            ClickSubmitButton();
            return this;
        }

    }
}
