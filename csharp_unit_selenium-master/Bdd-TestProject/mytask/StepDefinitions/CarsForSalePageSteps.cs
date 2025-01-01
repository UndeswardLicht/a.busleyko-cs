using Bdd_TestProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarsForSalePageSteps : BaseSteps
    {
        CarsForSalePage carsForSalePage = new();

        [Then("Cars for Sale page is displayed")]
        public void IsCarsForSaleDisplayed()
        {
            ClassicAssert.IsTrue(carsForSalePage.State.IsDisplayed);
        }

        [When(@"I select '(.*)' in Stock Type dropdown on Cars for Sale page")]
        public void SelectValueInStockType(string value)
        {
            carsForSalePage.SelectStockType(value);
        }

        [When(@"I select '(.*)' in Make dropdown on Cars for Sale page")]
        public void SelectValueInMake(string value)
        {
            carsForSalePage.SelectMaker(value);
        }

        [When(@"I select '(.*)' in Model dropdown on Cars for Sale page")]
        public void SelectValueInModel(string value)
        {
            carsForSalePage.SelectModel(value);
        }

        [When(@"I select '(.*)' in Price dropdown on Cars for Sale page")]
        public void SelectValueInPrice(string value)
        {
            carsForSalePage.SelectPrice(value);
        }

        [When(@"I select '(.*)' in Radius dropdown on Cars for Sale page")]
        public void SelectValueInDistance(string value)
        {
            carsForSalePage.SelectDistance(value);
        }

        [When(@"I enter '(.*)' in ZIP field on Cars for Sale page")]
        public void InputValueInZipField(string value)
        {
            carsForSalePage.EnterZip(value);
        }

        [When("I click Search button")]
        public void SelectValueInStockType()
        {
            carsForSalePage.ClickSearch();
        }


    }
}
