using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace AccuWeather_BDD.Pages
{
    internal class MainPage : BaseForm
    {
        private ILabel consentDataUsageButtonLabel = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'fc-button-label') and text() = 'Consent']"), "Consent data usage button");
        private ILabel closeDataPolicyBannerButton = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'banner-button policy-accept') and text() = 'I Understand']"), "I understand button on the banner");
        private ILabel searchField = ElementFactory.GetLabel(By.XPath("//input[contains(@class, 'search-input')]"), "search field");
        private ILabel firstResultFromDropdown = ElementFactory.GetLabel(By.XPath("(//*[contains(@class, 'results-container')]//div)[1]"), "first result from search dropdown");
        private ILabel firstRecentLocation = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'recent-location-item featured-location')]"), "first recent location label");
        private ILabel temperatureUnit = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'recent-location-temp-unit')]"), "temperature unit");        
        
        private ILabel resultFromDropdownByNumber(string value) => ElementFactory.GetLabel(By.XPath($"(//*[contains(@class, 'results-container')]//div)[{value}]"), $"result from search dropdown by number {value}");
        private ILabel useYourCurrentResultLabel = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'search-result')]//*[contains(text(), 'Use your current location')]"), "your currrent result label from search dropdown");
        
        public MainPage() : base(By.XPath("//*[contains(@class, 'recent-location-item featured-location')]"), "main Page")
        {
        }

        public void WriteInSearchField(string value)
        {
            searchField.SendKeys(value);
        }

        public string GetTemperatureUnits()
        {
            return temperatureUnit.GetText();
        }

        public void ClickFirstRecentLocation()
        {
            firstRecentLocation.ClickAndWait();
        }

        public void ClickSearchField()
        {
            searchField.Click();
        }

        public void ClickFirstResultFromDropdown(string resultLineNumber)
        {
            resultFromDropdownByNumber(resultLineNumber).ClickAndWait();
        }

        public bool IsYourCurrentResultLabelDisplayed()
        {
            return useYourCurrentResultLabel.State.IsDisplayed;
        }

        public bool IsResultContainerDisplayed()
        {
            return firstResultFromDropdown.State.WaitForDisplayed();
        }

        public bool IsConsentDataUsageBannerDisplayed()
        {
            return consentDataUsageButtonLabel.State.WaitForNotDisplayed();
        }

        public void ConsentDataUsage()
        {
           
            consentDataUsageButtonLabel.ClickAndWait();
        }
        public void ClosePolicyBanner()
        {
            closeDataPolicyBannerButton.ClickAndWait();
        }

    }
}
