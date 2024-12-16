using System;
using AQF = Aquality.Selenium.Forms;
using AQEI = Aquality.Selenium.Elements.Interfaces;
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
        //TODO ugly way for writing XPaths?
        private static By ThisTrimCountDoors = By.XPath("(//*[@class = 'key-specs-container']//label)[1]");
        private static By ThisTrimCountSeets = By.XPath("(//*[@class = 'key-specs-container']//label)[2]");
        private static By ThisTrimEngine = By.XPath("(//*[@class = 'key-specs-container']//label)[3]");
        //even more ugly
        private static By ThisTrimSpecEngine = By.XPath("(//*[@id='research-trim-specs']//*[@class='trims-table-data-point'])[1]");
        private static By ThisTrimSpecMpg = By.XPath("(//*[@id='research-trim-specs']//*[@class='trims-table-data-point'])[2]");
        private static By ThisTrimSpecSeating = By.XPath("(//*[@id='research-trim-specs']//*[@class='trims-table-data-point'])[4]");




        public ModelDescriptionPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, UniqeElement)), PageName)
        {
        }

        //TODO i believe it will return reference to an obj but maybe we don't need to??
        public Car AddCarDetails(Car someCar)
        {
            someCar.DoorCount = ElementFactory.GetLabel(ThisTrimCountDoors, "number of doors").Text;
            someCar.DoorCount = ElementFactory.GetLabel(ThisTrimCountSeets, "number of seats").Text;
            someCar.DoorCount = ElementFactory.GetLabel(ThisTrimEngine, "type of engine").Text;
            return someCar;
        }
    }
}
