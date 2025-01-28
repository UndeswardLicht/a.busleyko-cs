using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace AccuWeather_BDD.Pages
{
    internal class SettingsPage : BaseForm
    {
        private ILabel unitsDropdown = ElementFactory.GetLabel(By.XPath("//select[@id='unit']"), "units dropdown");
        private ILabel typeOfUnits(string value) => ElementFactory.GetLabel(
            By.XPath($"//select[@id='unit']/option[contains(text(), '{value}')]"), $"{value} units from dropdown");

        public SettingsPage() : base(By.XPath("//h1[contains(text(), 'settings')]"), "Settings page")
        {
        }

        public void SelectUnits(string value)
        {
            unitsDropdown.ClickAndWait();
            typeOfUnits(value).ClickAndWait();
        }
    }
}
