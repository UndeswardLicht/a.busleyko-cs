using System;
using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class ModelDescriptionPage : AQF.Form
    {
        private const string PageName = "Specific car model page";
        private const string UniqeElement = "Change trim";
        private static By ThisTrimEngine = By.XPath("//*[@id='research-trim-specs']//*[contains(text(), 'Engine Type')]/preceding-sibling::*");
        private IButton HeaderLogoButton = ElementFactory.GetButton(By.XPath(
    "//*[@id='cars-global-header']//a[@class='header-logo']"), "Go to Main Header logo");

        public ModelDescriptionPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, UniqeElement)), PageName)
        {
        }

        public Car AddCarDetails(Car someCar)
        {
            someCar.Engine = ElementFactory.GetLabel(ThisTrimEngine, "type of engine").Text;
            return someCar;
        }

        public void GoToMain()
        {
            HeaderLogoButton.Click();
        }
    }
}
