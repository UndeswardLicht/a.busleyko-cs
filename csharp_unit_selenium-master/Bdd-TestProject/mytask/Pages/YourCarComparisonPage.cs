using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace ExampleProject.mytask.Pages
{
    internal class YourCarComparisonPage : Aquality.Selenium.Forms.Form
    {
        private string priceCar = "(//*[@class='price-amount'])";
        public YourCarComparisonPage() : base(By.XPath("//*[@class='compare-add-button-container']"), "Your car comparison")
        {
        }

        public string retrievePriceCar(string whichCar)
        {
            ILabel price = ElementFactory.GetLabel(
                By.XPath(priceCar + $"[{whichCar}]"), $"price of the {whichCar} car");
            return "";
        }

    }
}
