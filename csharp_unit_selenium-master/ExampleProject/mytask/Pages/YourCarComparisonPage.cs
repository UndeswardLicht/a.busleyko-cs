using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace ExampleProject.mytask.Pages
{
    internal class YourCarComparisonPage : Aquality.Selenium.Forms.Form
    {
        private const string PageName = "Your car comparison";
        private static By uniqeElement = By.XPath("//*[@class='compare-add-button-container']");
        private ILabel priceFirstCar = ElementFactory.GetLabel(By.XPath("(//*[@class='price-amount'])[1]"), "price of first car");
        private ILabel priceSecondCar = ElementFactory.GetLabel(By.XPath("(//*[@class='price-amount'])[2]"), "price of second car");

        public YourCarComparisonPage() : base(uniqeElement, PageName)
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
