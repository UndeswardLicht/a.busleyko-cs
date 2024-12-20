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
        private static By UniqeElement = By.XPath("//*[@id='change-trim-popover']");
        private static By ThisTrimPrice = By.XPath("//*[@class='price-amount']");
        private IButton HeaderLogoButton = ElementFactory.GetButton(By.XPath(
    "//*[@id='cars-global-header']//a[@class='header-logo']"), "Go to Main Header logo");

        public ModelDescriptionPage() : base(UniqeElement, PageName)
        {
        }

        public Car AddCarDetails(Car someCar)
        {
            someCar.Price= ElementFactory.GetLabel(ThisTrimPrice, "price for it").Text;
            return someCar;
        }

        public void GoToMain()
        {
            HeaderLogoButton.Click();
        }
    }
}
