using Bdd_TestProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarsForSaleResultsPageSteps : BaseSteps
    {
        private readonly CarData carData;
        public CarsForSaleResultsPageSteps(CarData carData)
        {
            this.carData = carData;
        }
        private int priceOfFoundCar;

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

        [When("I check the checkbox with the remembered trim in the filters on the left")]
        public void CheckTheRememberedTrimInCheckbox()
        {
            carsForSaleResults.SelectSameTrim(carData.TrimName);
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
            priceOfFoundCar = carsForSaleResults.RetrieveFirstFoundCarPrice();
        }

        [Then("The price of the found used car is lower than the price of the remembered car")]
        public void ComparePricesOfFoundAndSavedCars()
        {
            ClassicAssert.IsTrue(carsForSaleResults.IsFoundCarCheaper(priceOfFoundCar, carData.Price));
        }
    }
}
