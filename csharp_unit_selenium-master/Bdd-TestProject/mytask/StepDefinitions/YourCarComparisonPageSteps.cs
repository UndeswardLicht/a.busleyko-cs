using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class YourCarComparisonPageSteps : BaseSteps
    {
        YourCarComparisonPage yourCarComparisonPage = new();

        [Then("Your cars comparison page is displayed")]
        public void IsComparisonPagedisplayed()
        {
            ClassicAssert.IsTrue(yourCarComparisonPage.State.IsDisplayed);
        }

        //TODO how to make this step work when
        //we compare two objects properties - carA and carB let's say
        [Then("The price for the carA is the same as it was remembered")]
        public void IsPriceTheSame()
        {
            ClassicAssert.AreEqual();
        }

    }
}
