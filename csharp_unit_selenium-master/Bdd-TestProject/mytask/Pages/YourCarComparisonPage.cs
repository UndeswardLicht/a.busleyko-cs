using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using Bdd_TestProject.mytask.Pages;

namespace ExampleProject.mytask.Pages
{
    internal class YourCarComparisonPage : BaseForm
    {
        private string priceCar = "(//*[@class='price-amount'])";
        public YourCarComparisonPage() : base(By.XPath("//*[@class='compare-add-button-container']"), "Your car comparison")
        {
        }

        public string retrieveCarPrice(string whichCar)
        {
            ILabel price = ElementFactory.GetLabel(
                By.XPath(priceCar + $"[{whichCar}]"), $"price of the {whichCar} car");
            return "";
        }

    }
}
