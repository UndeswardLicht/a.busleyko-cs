using System;
using System.Collections.Generic;
using System.Linq;
using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Core.Elements;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class ResearchAndReviewsPage : AQF.Form
    {
        private const string PageName = "Research & Reviews";
        private By SideBySide = By.XPath("//*[@data-linkname='research-compare']");
        private IButton ResearchButton = ElementFactory.GetButton(By.XPath(string.Format(
            LocatorConstants.PreciseClassLocator, "sds-field-group field-group-melded")), "Research button");
        private By MakeField = By.XPath(string.Format(LocatorConstants.PreciseIdLocator, "make-select"));
        private By ModelField = By.XPath(string.Format(LocatorConstants.PreciseIdLocator, "model-select"));
        private By YearField = By.XPath(string.Format(LocatorConstants.PreciseIdLocator, "year-select"));
        private IButton HeaderLogoButton = ElementFactory.GetButton(By.XPath(
            "//*[@id='cars-global-header']//a[@class='header-logo']"), "Go to Main Header logo");

        public ResearchAndReviewsPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void ClickForComparison()
        {
            ILink link = ElementFactory.GetLink(SideBySide, "Side-By-Side Comparison");
            link.Click();
        }
        public Car SelectCarInCombobox()
        {
            string maker = SelectElementsFromDropDown(MakeField);
            string model = SelectElementsFromDropDown(ModelField);
            string year = SelectElementsFromDropDown(YearField);

            return new Car(maker, model, year);
        }

        public void ClickResearchButton()
        {
            ResearchButton.Click();
        }

        private static string SelectElementsFromDropDown(By dropdown)
        {        
            IList<Element> list = ElementFactory.FindElements<Element>(dropdown);
            Random random = new Random();
            //starting from 2 because on 1st place is "All models" or smth like this
            int randomInt = random.Next(2, list.Count() + 1);
            return list[randomInt].GetElement().GetAttribute("value");
        }

        private void GoToMain()
        {
            HeaderLogoButton.Click();
        }
    }
}
