using System;
using AQF = Aquality.Selenium.Forms;
using AQEI = Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace ExampleProject.mytask.Pages
{
    internal class ModelDescriptionPage : AQF.Form
    {
        private const string PageName = "Specific car model page";
        private const string UniqeElement = "Change trim";

        public ModelDescriptionPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, UniqeElement)), PageName)
        {
        }

        public Car RetrieveCar()
        {
            return null;
        }
    }
}
