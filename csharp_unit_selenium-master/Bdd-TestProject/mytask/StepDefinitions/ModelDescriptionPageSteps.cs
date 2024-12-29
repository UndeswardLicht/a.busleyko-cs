using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    internal class ModelDescriptionPageSteps : BaseSteps
    {
        ModelDescriptionPage modelDescriptionPage = new();

        [Then("Model description page is displayed")]
        public void IsModelDescriptionDisplayed()
        {
            ClassicAssert.IsTrue(modelDescriptionPage.State.IsDisplayed);
        }

        //TODO implement later - undrst how to pass the data between tests
        [Then("The price for that model is remembered")]
        public void IsModelPriceRemembered()
        {
            ClassicAssert.IsTrue(modelDescriptionPage.);
        }
    }
}
