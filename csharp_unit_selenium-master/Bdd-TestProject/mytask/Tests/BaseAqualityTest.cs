using NUnit.Framework;
using AQB = Aquality.Selenium.Browsers;
using AQBS = Aquality.Selenium.Browsers.AqualityServices;


namespace ExampleProject.mytask.Tests
{
    internal class BaseAqualityTest

    {
        protected AQB.Browser browser = AQBS.Browser;
        protected static readonly string url = "http://www.cars.com/";

        [SetUp]
        public void Setup()
        {
            browser.Maximize();
            browser.GoTo(url);
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}
