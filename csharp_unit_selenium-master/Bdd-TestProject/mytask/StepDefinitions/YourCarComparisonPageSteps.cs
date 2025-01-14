using Bdd_TestProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class YourCarComparisonPageSteps
    {
        YourCarComparisonPage yourCarComparisonPage = new();

        [Then("Your cars comparison page is displayed")]
        public void IsComparisonPagedisplayed()
        {
            ClassicAssert.IsTrue(yourCarComparisonPage.State.WaitForDisplayed(new TimeSpan(0, 0, 15)), "Your cars comparison page is not displayed");
        }

        [Then(@"The price for the '(.*)' car is the same as it was remembered for the '(.*)'")]
        public void IsPriceTheSame(string whichCar ,string carName)
        {
            float? priceOfSavedCar = Store.Get<Car>(carName).Price;
            float? priceOnThePage = yourCarComparisonPage.RetrieveCarPrice(whichCar);
            ClassicAssert.IsTrue(priceOfSavedCar == priceOnThePage, "Cars prices are not the same");
        }

    }
}
