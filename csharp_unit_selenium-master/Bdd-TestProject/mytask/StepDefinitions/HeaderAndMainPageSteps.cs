using Bdd_TestProject.mytask.Pages;
using ExampleProject.mytask.Pages;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class HeaderAndMainPageSteps
    {
        CarsMainPage carsMainPage = new();

        [Given("Accept the banner conditions to remove it")]
        public void AcceptBanner()
        {
            carsMainPage.ClickAcceptOnBanner();
        }

        [When("I go back to Main page")]
        public void NavToMain()
        {
            carsMainPage.GoToMain();
        }

        [When("I go to Research & Reviews page")]
        public void NavToReviews()
        {
            carsMainPage.GoToResearchAndReviews();
        }

        [When("I go to Cars for Sale page")]
        public void NavToCarsForSale()
        {
            carsMainPage.GoToCarsForSale();
        }
    }
}
