using System;
using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace ExampleProject.mytask.Pages
{
    internal class CarDescriptionPage : AQF.Form
    {
        private const string PageName = "Selected car page";
        private const string UniqeElement = "Change year or car";
        private static readonly By FirstTrim = By.XPath("//*[@data-linkname='research-mmyt']");
        public CarDescriptionPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, UniqeElement)), PageName)
        {
        }

        public void SelectFirstTrim()
        {

        }
    }
}
