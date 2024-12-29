using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarsForSalePage : BaseForm
    {
        private static By StockType = By.XPath("//*[@id='make-model-search-stocktype']");
        private static By Make = By.XPath("//*[@id='makes");
        private static By Model = By.XPath("//*[@id='models']");
        private static By Price = By.XPath("//*[@id='make-model-max-price']");
        private static By Distance = By.XPath("//*[@id='make-model-maximum-distance']");
        private static By Zip = By.XPath("//*[@id='make-model-zip']");
        private static By SearchButton = By.XPath("//*[@id='panel-3']//spark-button");

        private ILabel stockTypeLabel = ElementFactory.GetLabel(StockType, "Stock Type label");
        private ILabel makeLabel = ElementFactory.GetLabel(Make, "Make label");
        private ILabel modelLabel = ElementFactory.GetLabel(Model, "Model label");
        private ILabel priceLabel = ElementFactory.GetLabel(Price, "Stock Type label");
        private ILabel distanceLabel = ElementFactory.GetLabel(Distance, "Distance label");
        private ILabel searchButtonLabel = ElementFactory.GetLabel(SearchButton, "Search button label");
        private ILabel zipInputLabel = ElementFactory.GetLabel(Zip, "ZIP input fiel label");

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
