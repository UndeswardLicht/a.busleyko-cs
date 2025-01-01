using Bdd_TestProject.mytask.Models;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class ModelDescriptionPageSteps : BaseSteps
    {
        ModelDescriptionPage modelDescriptionPage = new();

        [Then("Model description page is displayed")]
        public void IsModelDescriptionDisplayed()
        {
            ClassicAssert.IsTrue(modelDescriptionPage.State.IsDisplayed);
        }

        [Then(@"The price for that model of the '(.*)' is remembered")]
        public void IsModelPriceRemembered(string carName)
        {
            Store.Get<Car>(carName).Price = modelDescriptionPage.GetPriceOfThisCar();
            ClassicAssert.NotNull(Store.Get<Car>(carName).Price);
        }
    }
}
