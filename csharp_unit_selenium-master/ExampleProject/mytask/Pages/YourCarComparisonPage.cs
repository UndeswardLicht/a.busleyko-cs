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
        private ILabel priceFirstCar = ElementFactory.GetLabel(By.XPath("(//*[@class='price-amount'])[1]"), "price of first car");
        private ILabel priceSecondCar = ElementFactory.GetLabel(By.XPath("(//*[@class='price-amount'])[2]"), "price of second car");

        public YourCarComparisonPage() : base(UniqeElement, PageName)
        {
        }

        public string retrievePriceFirstCar()
        {
            return priceFirstCar.GetText();
        }
        public string retrievePriceSecondCar()
        {
            return priceSecondCar.GetText();
        }


    }
}
