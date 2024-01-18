using EsFramework.Config;
using EsFramework.Drivers;
using EsTests.Pages;

namespace EsTests
{
    public class UnitTest1: 
        IDisposable
    {
        private IDriverFixture _driverFixture;
        private PagesRepository _pagesFixture;

        public UnitTest1()
        {
            _driverFixture = new DriverFixture(BrowserType.Chrome);


            _pagesFixture = new PagesRepository(_driverFixture);
        }

        [Theory]
        [InlineData("Test123456!", "Test!123456")]
        public void ValidUserAndPasswordLogin(string user, string password)
        {
            _pagesFixture.HomePage.ClickLinkForTesting();
            _pagesFixture.ForTestingPage.FillInBoundaryValueForm(user, password);
        }

        public void Dispose()
        {
            _driverFixture.Driver.Quit();
        }
    }
}