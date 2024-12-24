using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;

namespace ExampleProject.mytask.Pages
{
    internal class ModelDescriptionPage : Aquality.Selenium.Forms.Form
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

        public void GoToMain()
        {
            HeaderLogoButton.Click();
        }
    }
}
