using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarsForSaleResultsPage : Aquality.Selenium.Forms.Form
    {
        private By Year = By.XPath("//spark-button[contains(text(), 'Year')]");
        private By Trim = By.XPath("//spark-button[contains(text(), 'Trim')]");

        public CarsForSaleResultsPage() : base(By.XPath("//li[contains(text(), 'Cars for Sale')]"), "Cars for sale - results page")
        {
        }
    }
}
