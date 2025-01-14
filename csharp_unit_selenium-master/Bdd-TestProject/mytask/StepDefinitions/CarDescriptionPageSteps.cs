using Bdd_TestProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;
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
            ClassicAssert.IsTrue(carDescriptionPage.State.WaitForDisplayed(new TimeSpan(0, 0, 15)), "Car description page is not displayed");
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
