using Bdd_TestProject.mytask.Models;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarDescriptionPageSteps
    {
        CarDescriptionPage carDescriptionPage = new();

        [Then("Car description page is displayed")]
        public void IsCarDescriptionPageDisplayed()
        {
            ClassicAssert.IsTrue(carDescriptionPage.State.IsDisplayed, "Car description page is not displayed");
        }

        [When(@"I remember the very first trim of the '(.*)'")]
        public void RememberTheFirstTrimName(string carName)
        {
            Store.Get<Car>(carName).Trim = carDescriptionPage.RememberTheFirstTrim();
        }

        [When("I select the very first trim of the car")]
        public void SelectFirstTrim()
        {
            carDescriptionPage.SelectFirstTrim();
        }

    }
}
