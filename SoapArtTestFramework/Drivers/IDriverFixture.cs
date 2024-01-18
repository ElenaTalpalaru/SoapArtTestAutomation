using EsFramework.Config;
using OpenQA.Selenium;

namespace EsFramework.Drivers
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }
}