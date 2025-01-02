using Bdd_TestProject.mytask.Pages;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    internal class BaseSteps
    {
        BaseForm baseForm = new();

        public void GoToMainAndAcceptBanner()
        {
            baseForm.GoToMain();
            baseForm.ClickAcceptOnBanner();
        }

        public void GoToMain()
        {
            baseForm.GoToMain();
        }

        public void GoToReviews()
        {
            baseForm.GoToResearchAndReviews();
        }

        public void GoToCarsForSale()
        {
            baseForm.GoToCarsForSale();
        }
    }
}
