using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarDescriptionPage : BaseForm
    {
        private readonly ILink FirstTrimLink = ElementFactory.GetLink(
    By.XPath("//*[@data-linkname='research-mmyt']"), "The very first trim");
        public CarDescriptionPage() : base(By.XPath("//*[contains(text(),'Change year or car')]"), "Selected car page")
        {
        }
        public void SelectFirstTrim()
        {
            FirstTrimLink.Click();
        }
        public string RememberTheFirstTrim()
        {
            return FirstTrimLink.GetText();
        }
    }
}
