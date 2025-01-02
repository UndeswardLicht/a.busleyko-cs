using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarsForSalePage : BaseForm
    {
        private ILabel stockTypeLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='make-model-search-stocktype']"), "Stock Type label");
        private ILabel makeLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='makes']"), "Make label");
        private ILabel modelLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='models']"), "Model label");
        private ILabel priceLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='make-model-max-price']"), "Price label");
        private ILabel distanceLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='make-model-maximum-distance']"), "Distance label");
        private ILabel searchButtonLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='panel-3']//spark-button"), "Search button label");
        private ILabel zipInputLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='make-model-zip']"), "ZIP input fiel label");

        private ILabel label(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "label");

        public CarsForSalePage() : base(By.XPath("//h1[contains(text(), 'Cars for sale')]"), "Cars for sale page")
        {
        }

        public void SelectStockType(string value)
        {
            stockTypeLabel.ClickAndWait();
            label(value).ClickAndWait();
        }
        public void SelectMaker(string value)
        {
            makeLabel.ClickAndWait();
            label(value).ClickAndWait();
        }
        public void SelectModel(string value)
        {
            modelLabel.ClickAndWait();
            label(value).ClickAndWait();
        }
        public void SelectPrice(string value)
        {
            priceLabel.ClickAndWait();
            label(value).ClickAndWait();
        }
        public void SelectDistance(string value)
        {
            distanceLabel.ClickAndWait();
            label(value).ClickAndWait();
        }
        public void EnterZip(string value)
        {
            zipInputLabel.SendKeys(value);
        }
        public void ClickSearch()
        {
            searchButtonLabel.Click();
        }

    }
}
