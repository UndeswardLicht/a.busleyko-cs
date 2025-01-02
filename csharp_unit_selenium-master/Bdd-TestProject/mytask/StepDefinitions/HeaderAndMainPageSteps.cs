using Bdd_TestProject.mytask.Pages;
using ExampleProject.mytask.Pages;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class HeaderAndMainPageSteps
    {
        //TODO ask here
        CarsMainPage carsMainPage = new();
        BaseForm baseForm = new();

        [Given("Accept the banner conditions to remove it")]
        public void AcceptBanner()
        {
            baseForm.ClickAcceptOnBanner();
        }

        [When("I go back to Main page")]
        public void NavToMain()
        {
            baseForm.GoToMain();
        }

        [When("I go to Research & Reviews page")]
        public void NavToReviews()
        {
            baseForm.GoToResearchAndReviews();
        }

        [When("I go to Cars for Sale page")]
        public void NavToCarsForSale()
        {
            baseForm.GoToCarsForSale();
        }
    }
}
