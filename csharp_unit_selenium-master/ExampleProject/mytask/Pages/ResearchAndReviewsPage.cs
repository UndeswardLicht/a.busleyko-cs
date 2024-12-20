using System;
using System.Linq;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;

namespace ExampleProject.mytask.Pages
{
    internal class ResearchAndReviewsPage : Aquality.Selenium.Forms.Form
    {
        private const string PageName = "Research & Reviews";
        private static By uniqueElement = By.XPath("//*[text()='Research & Reviews']");
        private By SideBySideComparison = By.XPath("//*[@data-linkname='research-compare']");
        private IButton ResearchButton = ElementFactory.GetButton(
            By.XPath("//*[@id='panel-2']//spark-button"), "Research button");
        private By MakeField = By.XPath("//*[@id='make-select']");
        private By ModelField = By.XPath("//*[@id='model-select']");
        private By YearField = By.XPath("//*[@id='year-select']");
        public ResearchAndReviewsPage() : base(uniqueElement, PageName)
        {
        }

        public void ClickForComparison()
        {
            ILink link = ElementFactory.GetLink(SideBySideComparison, "Side-By-Side Comparison");
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
