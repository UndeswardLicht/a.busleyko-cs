using AccuWeather_BDD.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace AccuWeather_BDD.StepDefinitions
{
    [Binding]
    internal class SettingsPageSteps
    {
        private SettingsPage settingsPage = new();

        [Then("The settings page is displayed")]
        public void isPageDisplayed()
        {
            ClassicAssert.IsTrue(settingsPage.State.WaitForDisplayed(), "settings page is not displayed");
        }
        
        [When (@"I select '(.*)' units")]
        public void SelectUnits(string units)
        {
            settingsPage.SelectUnits(units);
        }

    }
}
