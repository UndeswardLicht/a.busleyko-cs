using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class CompareCarsSideBySideSteps : BaseSteps
    {
        CompareCarsSideBySide compareCarsSideBySide = new();
        
        [Then("Compare Cars Side By Side page is displayed")]
        public void IsCompareSideBySideDisplayed()
        {
            ClassicAssert.IsTrue(compareCarsSideBySide.State.IsDisplayed);
        }

        [When(@"I select '(.*)' in Make dropdown in '(.*)' box")]
        public void SelectMakerInDropdown(string maker, string whichCar)
        {
            compareCarsSideBySide.SelectMakerInDropdown(maker, whichCar);
        }

        [When(@"I select '(.*)' in Model dropdown in '(.*)' box")]
        public void SelectModelInDropdown(string model, string whichCar)
        {
            compareCarsSideBySide.SelectModelInDropdown(model, whichCar);
        }
        [When(@"I select '(.*)' in Year dropdown in '(.*)' box")]
        public void SelectYearInDropdown(string year, string whichCar)
        {
            compareCarsSideBySide.SelectYearInDropdown(year, whichCar);
        }

        [When("I click See the comparison button")]
        public void ClickComparisonButton()
        {
            compareCarsSideBySide.ClickSearchButton();
        }

    }
}
