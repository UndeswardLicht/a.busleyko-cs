using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;

namespace ExampleProject.mytask.Pages
{
    internal class ModelDescriptionPage : BaseForm
    {
        private ILabel ThisTrimPrice = ElementFactory.GetLabel(By.XPath("//*[@class='price-amount']"), "price for it");
        public ModelDescriptionPage() : base(By.XPath("//*[@id='change-trim-popover']"), "Specific car model page")
        {
        }

        public Car AddCarDetails(Car someCar)
        {
            someCar.Price= ThisTrimPrice.Text;
            return someCar;
        }

        public int GetPriceOfThisCar()
        {
            int.TryParse(ThisTrimPrice.Text.Replace("$", string.Empty), out int price);
            return price;
        }

    }
}
