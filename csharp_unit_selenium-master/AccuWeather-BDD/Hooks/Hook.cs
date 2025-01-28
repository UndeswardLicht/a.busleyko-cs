using TechTalk.SpecFlow;
using AQB = Aquality.Selenium.Browsers;
using AQBS = Aquality.Selenium.Browsers.AqualityServices;
using AccuWeather_BDD.Models;

namespace AccuWeather_BDD.Hooks
{
    [Binding]
    internal class Hook
    {
        protected AQB.Browser browser = AQBS.Browser;
        protected static readonly string url = "https://www.accuweather.com/";

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
