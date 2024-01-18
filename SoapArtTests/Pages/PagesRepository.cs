using EsFramework.Drivers;

namespace EsTests.Pages
{
    public class PagesRepository
    {
        public readonly HomePage HomePage;
        public readonly ForTestingPage ForTestingPage;

        public PagesRepository(IDriverFixture driverFixture)
        {
            HomePage = new HomePage(driverFixture);
            ForTestingPage = new ForTestingPage(driverFixture);
        }
    }
}
