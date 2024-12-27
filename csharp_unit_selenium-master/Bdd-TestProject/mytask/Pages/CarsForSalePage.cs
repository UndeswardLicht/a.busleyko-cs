using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarsForSalePage : BaseForm
    {
        private By StockType = By.XPath("//*[@id='make-model-search-stocktype']");
        private By Make = By.XPath("//*[@id='makes");
        private By Model = By.XPath("//*[@id='models']");
        private By Price = By.XPath("//*[@id='make-model-max-price']");
        private By Distance = By.XPath("//*[@id='make-model-maximum-distance']");
        private By Zip = By.XPath("//*[@id='make-model-zip']");
        private By SearchButton = By.XPath("//*[@id='panel-3']//spark-button");


        public CarsForSalePage() : base(By.XPath("//h1[contains(text(), 'Cars for sale')]"), "Cars for sale page")
        {
        }

        //todo Add clicking the options in Box and dropdowns
    }
}
