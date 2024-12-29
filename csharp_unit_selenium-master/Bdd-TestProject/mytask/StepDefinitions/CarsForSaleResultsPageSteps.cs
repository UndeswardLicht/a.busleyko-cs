using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bdd_TestProject.mytask.Pages;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    internal class CarsForSaleResultsPageSteps : BaseSteps
    {
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
    }
}
