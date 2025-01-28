using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Actions;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AccuWeather_BDD.Pages
{

    internal class BaseForm : Aquality.Selenium.Forms.Form
    {
        private static By hamburgerMenuPath = By.XPath("//*[@data-qa='navigationMenu']");
        private ILabel hamburgerMenuButton = ElementFactory.GetLabel(hamburgerMenuPath, "hamburger manu button");
        private ILabel settingsPageButton = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'icon-settings')]"), "settings button in menu");
        private ILabel headerLogo = ElementFactory.GetLabel(By.XPath("//*[contains(@class, 'header-logo')]"), "logo in header");

        public BaseForm() : base(hamburgerMenuPath, "base form page")
        {
        }
        public BaseForm(By locator, string name) : base(locator, name)
        {
        }

        public void GoToMain()
        {
            headerLogo.ClickAndWait();
        }

        public void OpenHamburgerMenu()
        {
            hamburgerMenuButton.ClickAndWait();
 
        }
        public void OpenSettings()
        {
            settingsPageButton.ClickAndWait();
        }
       
    }
}
