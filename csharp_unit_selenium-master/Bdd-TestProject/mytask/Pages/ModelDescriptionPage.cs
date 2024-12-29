using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;

namespace ExampleProject.mytask.Pages
{
    internal class ModelDescriptionPage : BaseForm
    {
        private ILabel ThisTrimPrice = ElementFactory.GetLabel(By.XPath("//*[@class='price-amount']"), "price for it");
        private IButton HeaderLogoButton = ElementFactory.GetButton(By.XPath(
    "//*[@id='cars-global-header']//a[@class='header-logo']"), "Go to Main Header logo");

        public ModelDescriptionPage() : base(By.XPath("//*[@id='change-trim-popover']"), "Specific car model page")
        {
        }

        public Car AddCarDetails(Car someCar)
        {
            someCar.Price= ThisTrimPrice.Text;
            return someCar;
        }

        public string GetPriceOfThisCar()
        {
            return ThisTrimPrice.Text;
        }

        //public void GoToMain()
        //{
        //    HeaderLogoButton.Click();
        //}
    }
}
