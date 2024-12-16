using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AQ = Aquality.Selenium;
using AQB = Aquality.Selenium.Browsers;
using AQBS = Aquality.Selenium.Browsers.AqualityServices;


namespace ExampleProject.mytask.Tests
{
    internal class BaseAqualityTest

    {
        protected AQB.Browser browser = AQBS.Browser;
        protected static readonly string url = "http://www.cars.com";

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
