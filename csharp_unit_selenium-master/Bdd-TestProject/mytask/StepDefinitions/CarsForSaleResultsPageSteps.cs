using Bdd_TestProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;
using ExampleProject.mytask.Models;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarsForSaleResultsPageSteps : BaseSteps
    {
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

        [When(@"I check the checkbox with the trim of the remembered '(.*)' in the filters on the left")]
        public void CheckTheRememberedTrimInCheckbox(string carName)
        {
            carsForSaleResults.SelectSameTrim(Store.Get<Car>(carName).Trim);
        }

        [When(@"I select '(.*)' in Min year dropdown on in the filters on the left ")]
        public void SelectValueInMinYearDropdown(string minYear)
        {
            carsForSaleResults.SelectMinYear(minYear);
        }

        [When(@"I select '(.*)' in Max year dropdown on in the filters on the left ")]
        public void SelectValueInMaxYearDropdown(string maxYear)
        {
            carsForSaleResults.SelectMaxYear(maxYear);
        }

        [When("I retrieve the price of the found car")]
        public void RetriecePricesOfFoundCar()
        {
            priceOfFoundCar = carsForSaleResults.RetrieveFirstFoundCarPrice();
        }

        [Then(@"The price of the found used car is lower than the price of the remembered '(.*)'")]
        public void ComparePricesOfFoundAndSavedCars(string carName)
        {
            int priceOfSavedCar = (int)Store.Get<Car>(carName).Price;
            ClassicAssert.IsTrue(carsForSaleResults.IsFoundCarCheaper(priceOfFoundCar, priceOfSavedCar));
        }
    }
}
