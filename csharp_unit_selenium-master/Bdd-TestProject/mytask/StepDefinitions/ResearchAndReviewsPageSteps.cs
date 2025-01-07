using Bdd_TestProject.mytask.Models;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class ResearchAndReviewsPageSteps
    {
        ResearchAndReviewsPage researchAndReviewsPage = new();

        [Then("Research & Reviews page is displayed")]
        public void IsResearchPageDisplayed()
        {
            ClassicAssert.IsTrue(researchAndReviewsPage.State.IsDisplayed, "Research & Reviews page is not displayed");
        }

        [When(@"I select '(.*)' in Make dropdown as '(.*)'")]
        public void SelectValueInMakeDropdown(string value, string carName)
        {
            researchAndReviewsPage.SelectSpecificMakerInCombobox(value);
            Store.Get<Car>(carName).Maker = value;
        }

        [When(@"I select '(.*)' in Model dropdown as '(.*)'")]
        public void SelectValueInModelDropdown(string value, string carName)
        {
            researchAndReviewsPage.SelectSpecificModelInCombobox(value);
            Store.Get<Car>(carName).Model = value;
        }

        [When(@"I select '(.*)' in Year dropdown as '(.*)'")]
        public void SelectValueInYearDropdown(string value, string carName)
        {
            researchAndReviewsPage.SelectSpecificYearInCombobox(value);
            Store.Get<Car>(carName).Year = value;
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
