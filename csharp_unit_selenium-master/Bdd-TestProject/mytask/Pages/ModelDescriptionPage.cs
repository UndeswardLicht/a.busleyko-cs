using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;

namespace ExampleProject.mytask.Pages
{
    internal class ModelDescriptionPage : BaseForm
    {
        private ILabel ThisTrimPrice = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'price-amount')]"), "price for it");
        public ModelDescriptionPage() : base(By.XPath("//*[@id='change-trim-popover']"), "Specific car model page")
        {
        }

        public Car AddCarDetails(Car someCar)
        {
            int.TryParse(ThisTrimPrice.Text.Trim('$'), out int price);
            someCar.Price = price;
            return someCar;
        }

        public float GetPriceOfThisCar()
        {
            string s = ThisTrimPrice.Text.Trim('$');
            return Single.Parse(s);
        }

    }
}
