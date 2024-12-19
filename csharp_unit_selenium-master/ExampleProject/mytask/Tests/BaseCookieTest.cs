using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ExampleProject.mytask.Tests
{
    internal class BaseCookieTest
    {
        protected WebDriver driver;
        protected static readonly string url = "http://example.com/";
        protected WebDriverWait wait = null;
        protected static readonly int maxWait = 10;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWait));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
