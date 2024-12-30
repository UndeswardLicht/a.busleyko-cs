using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bdd_TestProject.mytask.Pages;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarsForSaleResultsPageSteps : BaseSteps
    {
        private CarsForSaleResultsPage carsForSaleResults = new();

        [Then ("Cars for Sale results page is displayed")]
        public void IsResultPageDisplayed()
        {
            ClassicAssert.IsTrue(carsForSaleResults.State.IsDisplayed);
        }

        [Then("At least one car is found")]
        public void IsOneCarFound()
        {
            ClassicAssert.IsTrue(carsForSaleResults.IsSomethingFound());
        }

        //todo to work with remembered value
        [When("I check the checkbox with the remembered trim in the filters on the left")]
        public void CheckTheRememberedTrimInCheckbox(string trim)
        {
            carsForSaleResults.SelectSameTrim(trim);
        }

        [When("I select '(.*)' in Min year dropdown on in the filters on the left ")]
        public void SelectValueInMinYearDropdown(string minYear)
        {
            carsForSaleResults.SelectMinYear(minYear);
        }

        [When("I select '(.*)' in Max year dropdown on in the filters on the left ")]
        public void SelectValueInMaxYearDropdown(string maxYear)
        {
            carsForSaleResults.SelectMaxYear(maxYear);
        }

        [When("I retrieve the price of the found car")]
        public void RetriecePricesOfFoundCar()
        {
            carsForSaleResults.RetrieveFirstFoundCarPrice();
        }

        //todo add prices
        [Then("The price of the found used car is lower than the price of the remembered car")]
        public void ComparePricesOfFoundAndSavedCars()
        {
            ScenarioContext.Current["Price"] = 0;
            ClassicAssert.IsTrue(carsForSaleResults.IsFoundCarCheaper());
        }
    }
}
