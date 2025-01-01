using Bdd_TestProject.mytask.Pages;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    internal class BaseSteps
    {
        BaseForm baseForm = new();

        [Given("Accept the banner conditions to remove it")]
        public void GoToMainAndAcceptBanner()
        {
            baseForm.GoToMain();
            baseForm.ClickAcceptOnBanner();
        }

        [When("I go back to Main page")]
        public void GoToMain()
        {
            baseForm.GoToMain();
        }

        [When("I go to Research & Reviews page")]
        public void GoToReviews()
        {
            baseForm.GoToResearchAndReviews();
        }

        [When("I go to Cars for Sale page")]
        public void GoToCarsForSale()
        {
            baseForm.GoToCarsForSale();
        }
    }
}
