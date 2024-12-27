using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using Bdd_TestProject.mytask.Pages;

namespace ExampleProject.mytask.Pages
{
    internal class CarsMainPage : BaseForm
    {
        private IButton acceptBannerButton = ElementFactory.GetButton(By.Id("onetrust-accept-btn-handler"), "Accept all on banner button");
        private ILink reviewsPageLink = ElementFactory.GetLink(By.XPath(
            "//header//*[@data-linkname = 'header-research']"), "Link to go to Research & Reviews page"); 

        public CarsMainPage() : base(By.XPath("//*[contains(text(),'Popular categories')]"), "Cars - Main Page")
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
