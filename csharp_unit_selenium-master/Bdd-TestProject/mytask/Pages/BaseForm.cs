using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class BaseForm : Aquality.Selenium.Forms.Form
    {
        private static string headerLinks = "//*[@id='cars-global-header']//ul[contains(@class, 'header-links')]";

        private ILabel researchAndReviewsLabel = ElementFactory.GetLabel(
            By.XPath(headerLinks + "//*[@data-linkname='header-research']"), "Research & Reviews label");

        private ILabel carsForSaleLabel = ElementFactory.GetLabel(
            By.XPath(headerLinks + "//*[@data-linkname='header-buy']"), "Cars for Sale label");

        private ILabel headerMainLabel = ElementFactory.GetLabel(
            By.XPath(headerLinks + "//ancestor::header//*[@data-linkname='header-home']"), "Header main label");
        
        private IButton acceptBannerButton = ElementFactory.GetButton(
            By.Id("onetrust-accept-btn-handler"), "Accept all on banner button");
        public BaseForm() : base(By.XPath(headerLinks), "Cars-Global Header")
        {
        }
        public BaseForm(By locator, string name) : base(locator, name)
        {
        }

        public void GoToMain()
        {
            headerMainLabel.Click();
        }
        public void GoToResearchAndReviews()
        {
            researchAndReviewsLabel.Click();
        }

        public void GoToCarsForSale()
        {
            carsForSaleLabel.Click();
        }

        public void ClickAcceptOnBanner()
        {
            acceptBannerButton.Click();
        }
    }
}
