using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CarDescriptionPageSteps : BaseSteps
    {
        CarDescriptionPage carDescriptionPage = new();

        [Then("Car description page is displayed")]
        public void IsCarDescriptionPageDisplayed()
        {
            ClassicAssert.IsTrue(carDescriptionPage.State.IsDisplayed);
        }

        [When("I select the very first trim of the car")]
        public void SelectFirstTrim()
        {
            carDescriptionPage.SelectFirstTrim();
        }
    }
}
