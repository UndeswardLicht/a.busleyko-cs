
using AccuWeather_BDD.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace AccuWeather_BDD.StepDefinitions
{
    [Binding]
    internal class CityWeatherPageSteps
    {
        private CityWeatherPage cityWeatherPage = new();

        [Then(@"The city weather page header contains the city name '(.*)'")]
        public void DoesContainRightCityName(string cityName)
        {
            ClassicAssert.IsTrue(cityWeatherPage.GetLocationFromWeatherPage().Equals(cityName), "cities from search and from weather page are not euqal");
        }

    }
}
