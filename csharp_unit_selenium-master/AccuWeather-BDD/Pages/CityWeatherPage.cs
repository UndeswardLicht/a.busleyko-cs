
using System.Text.RegularExpressions;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace AccuWeather_BDD.Pages
{
    internal class CityWeatherPage : BaseForm
    {
        private static By locationInHeader = By.XPath("//h1[contains(@class, 'header-loc')]");
        private ILabel locationInHeaderLabel = ElementFactory.GetLabel(locationInHeader, "location text in header");
        public CityWeatherPage() : base(locationInHeader, "City weather page")
        {
        }

        public string GetLocationFromWeatherPage()
        {
            return  locationInHeaderLabel.GetText().Split(',')[0];
        }


    }
}
