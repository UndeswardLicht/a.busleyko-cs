using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class BaseForm : Aquality.Selenium.Forms.Form
    {
        private static string headerLinks = "//*[@id='cars-global-header']//ul[@class='header-links']";
        private static By researchAndReviews = By.XPath(headerLinks + "//*[@data-linkname='header-research']");
        private ILabel researchAndReviewsLabel = ElementFactory.GetLabel(researchAndReviews, "Research & Reviews label");
        private static By carsForSale = By.XPath(headerLinks + "//*[@data-linkname='header-buy']");
        private ILabel carsForSaleLabel = ElementFactory.GetLabel(carsForSale, "Cars for Sale label");
        private static By headerLogo = By.XPath(headerLinks + "//ancestor::header//*[@data-linkname='header-home']");
        private ILabel headerLabel = ElementFactory.GetLabel(headerLogo, "Header main label");
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
            headerLabel.Click();
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

        public void ScrollDownABit()
        {
            ScrollBy(-50, 0);
        }
    }
}
