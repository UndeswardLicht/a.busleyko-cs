using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace ExampleProject.mytask.Pages
{
    internal class CarsMainPage : Aquality.Selenium.Forms.Form
    {
        private IButton acceptBannerButton = ElementFactory.GetButton(By.Id("onetrust-accept-btn-handler"), "Accept all on banner button");
        private const string PageName = "Cars - Main Page";
        private static By uniqueElement = By.XPath("//*[contains(text(),'Popular categories')]");
        private ILink reviewsPageLink = ElementFactory.GetLink(By.XPath(
            "//header//*[@data-linkname = 'header-research']"), "Link to go to Research & Reviews page"); 

        public CarsMainPage() : base(uniqueElement, PageName)
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
