using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarsForSaleResultsPage : BaseForm
    {
        private static By minYear = By.XPath("//*[@id='year_year_min_select']");
        private static By maxYear = By.XPath("//*[@id='year_year_max_select']");
        private static By trims = By.XPath("//*[@id='trim']//*[contains(text(), 'trims')]");

        private ILabel MinYearLabel = ElementFactory.GetLabel(minYear, "min year label");
        private ILabel MaxYearLabel = ElementFactory.GetLabel(maxYear, "max year label");
        private ILabel yearLabel(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "year label");
        private ILabel trimLabel(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "trim label");


        public CarsForSaleResultsPage() : base(By.XPath("//li[contains(text(), 'Cars for Sale')]"), "Cars for sale - results page")
        {
        }

        public void SelectMinYear(string minYear)
        {
            MinYearLabel.ClickAndWait();
            yearLabel(minYear).ClickAndWait();
        }

        public void SelectMaxYear(string maxYear)
        {
            MaxYearLabel.ClickAndWait();
            yearLabel(maxYear).ClickAndWait();
        }

        public void SelectSameTrim(Car car)
        {
            //*[@id='trim']//*[contains(text(), 'Pop')]
            car.Trim;
        }
    }
}
