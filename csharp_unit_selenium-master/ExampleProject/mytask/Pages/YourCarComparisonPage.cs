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
    {
        private const string PageName = "Your car comparison";
        private static By UniqeElement = By.XPath(string.Format(LocatorConstants.PreciseClassLocator, "compare-add-button-container"));
        //private By engineFirstCar = By.XPath("(//*[@data-qa ='engine_type_data'])[1]/*[@class='data-point']");
        //private By engineSecondCar = By.XPath("(//*[@data-qa ='engine_type_data'])[2]/*[@class='data-point']");

        private ILabel engineFirstCar = ElementFactory.GetLabel(By.XPath("(//*[@data-qa ='engine_type_data'])[1]/*[@class='data-point']"), "engine");
        private ILabel engineSecondCar = ElementFactory.GetLabel(By.XPath("(//*[@data-qa ='engine_type_data'])[2]/*[@class='data-point']"), "engine");

        public YourCarComparisonPage() : base(UniqeElement, PageName)
        {
        }

        public string retrieveEngineFirstCar()
        {
            return engineFirstCar.GetText();
        }
        public string retrieveEngineSecondCar()
        {
            return engineSecondCar.GetText();
        }

        

    }
}
