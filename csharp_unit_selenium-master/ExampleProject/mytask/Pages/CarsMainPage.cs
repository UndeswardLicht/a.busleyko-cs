using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class CarsMainPage : AQF.Form
    {
        private IButton acceptBannerButton = ElementFactory.GetButton(By.Id("onetrust-accept-btn-handler"), "Accept all on banner button");
        private const string PageName = "Cars - Main Page";
        private const string uniqueElement = "Popular categories";
        private ILink reviewsPageLink = ElementFactory.GetLink(By.XPath(
            "//header//*[@data-linkname = 'header-research']"), "Link to go to Research & Reviews page"); 

        public CarsMainPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, uniqueElement)), PageName)
        {
        }

        public void GoToReviews()
        {
            reviewsPageLink.Click();
        }

        public void ClickAcceptAllOnBanner()
        {
            acceptBannerButton.Click();
        }

    }
}
