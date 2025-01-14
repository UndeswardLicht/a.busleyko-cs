using Bdd_TestProject.mytask.Models;
using TechTalk.SpecFlow;
using AQB = Aquality.Selenium.Browsers;
using AQBS = Aquality.Selenium.Browsers.AqualityServices;

namespace Bdd_TestProject.mytask
{

    [Binding]
    internal class Hook
    {
        protected AQB.Browser browser = AQBS.Browser;
        protected static readonly string url = "http://www.cars.com/";

        [BeforeScenario]
        public void Setup()
        {
            browser.Maximize();
            browser.GoTo(url);
            browser.WaitForPageToLoad();
        }

        [AfterScenario]
        public void TearDown()
        {
            browser.Quit();
            Store.CleanStore();

        }
    }
}
