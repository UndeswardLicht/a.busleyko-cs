using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class CarDescriptionPage : AQF.Form
    {
        private const string PageName = "Selected car page";
        private const string UniqeElement = "Change year or car";
        private IButton HeaderLogoButton = ElementFactory.GetButton(By.XPath(
    "//*[@id='cars-global-header']//a[@class='header-logo']"), "Go to Main Header logo");
        private IButton ReviewsButton = ElementFactory.GetButton(By.XPath(
    "//header//*[@data-linkname='header-research']"), "Go to Research & Reviews button");
        private readonly ILink FirstTrimLink = ElementFactory.GetLink(
    By.XPath("//*[@data-linkname='research-mmyt']"), "The very first trim");
        public CarDescriptionPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, UniqeElement)), PageName)
        {
        }

        public bool CheckTrims()
        {
            return FirstTrimLink.State.IsDisplayed;
        }
        public void SelectFirstTrim()
        {
            FirstTrimLink.Click();
        }
        public void GoToMain()
        {
            HeaderLogoButton.Click();
        }
        public void GoToReviews()
        {
            ReviewsButton.Click();
        }
    }
}
