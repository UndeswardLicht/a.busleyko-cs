using System;
using AQF = Aquality.Selenium.Forms;
using AQEI = Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using System.Reflection.Metadata;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class YourCarComparisonPage : AQF.Form
    //TODO should it be a separate page from CompareCarsSideBySide page??
    {
        private const string PageName = "Your car comparison";
        private static By UniqeElement = By.XPath(string.Format(LocatorConstants.PreciseClassLocator, "compare-add-button-container"));
        public YourCarComparisonPage() : base(UniqeElement, PageName)
        {
        }


    }
}
