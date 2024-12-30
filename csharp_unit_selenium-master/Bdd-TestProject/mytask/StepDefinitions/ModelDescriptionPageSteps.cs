using Bdd_TestProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class ModelDescriptionPageSteps : BaseSteps
    {
        private readonly CarData carData;
        public ModelDescriptionPageSteps(CarData carData)
        {
            this.carData = carData;
        }

        ModelDescriptionPage modelDescriptionPage = new();

        [Then("Model description page is displayed")]
        public void IsModelDescriptionDisplayed()
        {
            ClassicAssert.IsTrue(modelDescriptionPage.State.IsDisplayed);
        }

        //TODO how to make this step work when
        //we remember two objects properties - carA price and carB price let's say
        [Then("The price for that model is remembered")]
        public void IsModelPriceRemembered()
        {
            carData.Price = modelDescriptionPage.GetPriceOfThisCar();
            ClassicAssert.NotNull(carData.Price);
        }
    }
}
