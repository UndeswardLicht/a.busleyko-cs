using Bdd_TestProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarDescriptionPageSteps : BaseSteps
    {
        private readonly CarData carData;
        public CarDescriptionPageSteps(CarData carData)
        {
            this.carData = carData;
        }

        CarDescriptionPage carDescriptionPage = new();

        [Then("Car description page is displayed")]
        public void IsCarDescriptionPageDisplayed()
        {
            ClassicAssert.IsTrue(carDescriptionPage.State.IsDisplayed);
        }

        [When("I remember the very first trim of the car")]
        public void RememberTheFirstTrimName()
        {
            carData.TrimName = carDescriptionPage.RememberTheFirstTrim();
        }

        [When("I select the very first trim of the car")]
        public void SelectFirstTrim()
        {
            carDescriptionPage.SelectFirstTrim();
        }

    }
}
