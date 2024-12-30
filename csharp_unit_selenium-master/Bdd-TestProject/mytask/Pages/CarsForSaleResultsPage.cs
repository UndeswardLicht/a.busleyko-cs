﻿using System;
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
        private ILabel noCarsFoundLabel = ElementFactory.GetLabel(By.XPath("//h3//*[contains(text(), 'No exact matches found')]"), "nothing found label");

        private ILabel MinYearLabel = ElementFactory.GetLabel(minYear, "min year label");
        private ILabel MaxYearLabel = ElementFactory.GetLabel(maxYear, "max year label");
        private ILabel yearLabel(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "year label");
        private ICheckBox trimCheckBox(string value) => ElementFactory.GetCheckBox(By.XPath($"//*[@id='trim']//*[contains(text(), '{value}')]//preceding-sibling::input"), "trim chckbox");
        private ILabel priceOfFirstFoundCar = ElementFactory.GetLabel(By.XPath("(//*[@data-qa='primary-price'])[1]"), "price of the first found car label");
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

        //todo to work with car instead of single string
        public void SelectSameTrim(string value)
        {
            trimCheckBox(value).Check();
        }

        public bool IsSomethingFound()
        {
            return !noCarsFoundLabel.State.IsDisplayed;
        }

        //TODO to work with found and saved prices
        public void RetrieveFirstFoundCarPrice()
        {
            int.TryParse(priceOfFirstFoundCar.GetText().Replace("$", string.Empty), out int price);
            //todo do smth with price
        }

        public bool IsFoundCarCheaper(int foundCar, int savedCar)
        {
            return foundCar < savedCar;
        }
    }
}
