using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium;
using Aquality.Selenium.Browsers;

namespace ExampleProject.Selenium
{
    internal class BaseAqualityTest
    {
       public void firstTest()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo("http://www.cars.com");
            browser.WaitForPageToLoad();
        }
    }
}
