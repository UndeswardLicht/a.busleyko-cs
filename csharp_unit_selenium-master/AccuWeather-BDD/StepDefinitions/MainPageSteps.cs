using AccuWeather_BDD.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace AccuWeather_BDD.StepDefinitions
{
    [Binding]
    internal class MainPageSteps
    {
        private MainPage mainPage = new();

        [Then("Main page is displayed")]
        public void PageIsDisplayed()
        {
            ClassicAssert.IsTrue(mainPage.State.WaitForDisplayed(), "main page is not displayed");
        }

        [When("I consent data usage")]
        public void ConsentDataUsage()
        {
            mainPage.ConsentDataUsage();
        }

        [Then("The data usage banner is dissmissed")]
        public void NoDataUsageBannerIsDisplayed()
        {
            ClassicAssert.IsTrue(mainPage.IsConsentDataUsageBannerDisplayed(), "consent data banner is still displayed");
        }

        [When(@"I input '(.*)' in the search field" )]
        public void EnterValueInSearchField(string city)
        {
            mainPage.WriteInSearchField(city);
        }

        [Then("The search results list is displayed")]
        public void IsSearchResultDisplayed()
        {
            ClassicAssert.IsTrue(mainPage.IsResultContainerDisplayed(), "search results are not displayed");
        }

        [When (@"I click on the '(.*)'st search result")]
        public void ClickFirstSearchResult(string number)
        {
            mainPage.ClickFirstResultFromDropdown(number);
        }

        [When ("I choose the first city in Recent locations")]
        public void ClickRecentLocations()
        {
            mainPage.ClickFirstRecentLocation();
        }

        [When ("I click the search field")]
        public void ClickSearchField()
        {
            mainPage.ClickSearchField();
        }

        [Then ("The 'Use your current location' label is displayed")]
        public void UseYourLocationLabelIsDisplayed()
        {
            ClassicAssert.IsTrue(mainPage.IsYourCurrentResultLabelDisplayed(), "your current location label is not displayed");
        }

        [When("I click on the header menu")]
        public void CLickHeaderMenu()
        {
            mainPage.OpenHamburgerMenu();
        }

        [When ("I click on the Settings link")]
        public void ClickSettings()
        {
            mainPage.OpenSettings();
        }

        [Then ("The temperature is indicated in '(.*)' units")]
        public void CheckoutTempUnits(string units)
        {
            ClassicAssert.IsTrue(mainPage.GetTemperatureUnits().Equals(units), "temperature units are not euqal");
        }
        
        [When("I go to the Main page")]
        public void GoToMain()
        {
            mainPage.GoToMain();
        }
    }
}
