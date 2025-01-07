using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using Bdd_TestProject.mytask.Pages;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.ClipRectangle;

namespace ExampleProject.mytask.Pages
{
    internal class YourCarComparisonPage : BaseForm
    {
        private ILabel priceLabel(string value) => ElementFactory.GetLabel(
                By.XPath("(//*[@class='price-amount'])" + $"[{value}]"), $"price of the {value} car");
        public YourCarComparisonPage() : base(By.XPath("//*[@class='compare-add-button-container']"), "Your car comparison")
        {
        }

        public int RetrieveCarPrice(string whichCar)
        {
            int.TryParse(priceLabel(whichCar).GetText().Trim('$'), out int price);
            return price;


        }
    }
}
