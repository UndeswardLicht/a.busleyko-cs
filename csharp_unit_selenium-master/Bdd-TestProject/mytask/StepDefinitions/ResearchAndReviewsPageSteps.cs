using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class ResearchAndReviewsPageSteps : BaseSteps
    {
        ResearchAndReviewsPage researchAndReviewsPage = new();

        [Then("Research & Reviews page is displayed")]
        public void IsResearchPageDisplayed()
        {
            ClassicAssert.IsTrue(researchAndReviewsPage.State.IsDisplayed);
        }

        [When("I select '(.*)' in Make dropdown")]
        public void SelectValueInMakeDropdown(string value)
        {
            researchAndReviewsPage.SelectSpecificMakerInCombobox(value);
        }

        [When("I select '(.*)' in Model dropdown")]
        public void SelectValueInModelDropdown(string value)
        {
            researchAndReviewsPage.SelectSpecificModelInCombobox(value);
        }

        [When("I select '(.*)' in Year dropdown")]
        public void SelectValueInYearDropdown(string value)
        {
            researchAndReviewsPage.SelectSpecificYearInCombobox(value);
        }

        [When("Click Research button")]
        public void ClickResearchButton()
        {
            researchAndReviewsPage.ClickResearchButton();
        }

        [When("I click Compare Cars Side-By-Side link")]
        public void ClickCompareModelsLink()
        {
            researchAndReviewsPage.ClickForComparison();
        }
    }
}
