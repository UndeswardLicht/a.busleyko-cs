using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace Bdd_TestProject.mytask.Pages
{
    internal class YourCarComparisonPage : BaseForm
    {
        private ILabel priceLabel(string value) => ElementFactory.GetLabel(
                By.XPath("(//*[contains(@class, 'price-amount')])" + $"[{value}]"), $"price of the {value} car");
        public YourCarComparisonPage() : base(By.XPath("//*[@class='compare-add-button-container']"), "Your car comparison")
        {
        }

        public float RetrieveCarPrice(string whichCar)
        {
            string s = priceLabel(whichCar).GetText().Trim('$');
            return Single.Parse(s);
        }
    }
}
