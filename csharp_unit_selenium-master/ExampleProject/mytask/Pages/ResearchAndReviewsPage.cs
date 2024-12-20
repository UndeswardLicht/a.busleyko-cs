using System;
using System.Linq;
using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class ResearchAndReviewsPage : AQF.Form
    {
        private const string PageName = "Research & Reviews";
        private By SideBySide = By.XPath("//*[@data-linkname='research-compare']");
        private IButton ResearchButton = ElementFactory.GetButton(
            By.XPath("//*[@id='panel-2']//spark-button"), "Research button");
        private By MakeField = By.XPath("//*[@id='make-select']");
        private By ModelField = By.XPath("//*[@id='model-select']");
        private By YearField = By.XPath("//*[@id='year-select']");
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
            Random random = new Random();
            IComboBox drp = ElementFactory.GetComboBox(dropdown, "dropdown");
            drp.WaitAndClick();
            int randomInt = random.Next(1, drp.Values.Count());
            drp.SelectByIndex(randomInt);
            return drp.SelectedText;
        }

    }
}
