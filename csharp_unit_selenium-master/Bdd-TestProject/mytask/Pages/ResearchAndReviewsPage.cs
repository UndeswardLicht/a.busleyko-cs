using System;
using System.Linq;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;

namespace ExampleProject.mytask.Pages
{
    internal class ResearchAndReviewsPage : Aquality.Selenium.Forms.Form
    {
        private IButton ResearchButton = ElementFactory.GetButton(
            By.XPath("//*[@id='panel-2']//spark-button"), "Research button");
        private ILink SideBySideComparisonLink = ElementFactory.GetLink(
            By.XPath("//*[@data-linkname='research-compare']"), "Side-By-Side Comparison");
        private By MakeField = By.XPath("//*[@id='make-select']");
        private By ModelField = By.XPath("//*[@id='model-select']");
        private By YearField = By.XPath("//*[@id='year-select']");
        private ILabel label(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "label");

        public ResearchAndReviewsPage() : base(By.XPath("//*[text()='Research & Reviews']"), "Research & Reviews")
        {
        }

        public void ClickForComparison()
        {
            SideBySideComparisonLink.Click();
        }

        //Next method selects from dropdown a specific car 
        //provided as an argument and returns nothing
        public void SelectSpecificCarInCombobox(Car car)
        {
            ILabel makeCar = ElementFactory.GetLabel(MakeField, "maker dropdown of the car");
            ILabel modelCar = ElementFactory.GetLabel(ModelField, "model dropdown of the car");
            ILabel yearCar = ElementFactory.GetLabel(YearField, "year dropdown of the car");

            makeCar.ClickAndWait();
            label(car.Maker).ClickAndWait();
            modelCar.ClickAndWait();
            label(car.Model).ClickAndWait();
            yearCar.ClickAndWait();
            label(car.Year).ClickAndWait();
        }

        //Next two methods select a random car from dropdown and return a Car object
        public Car SelectRandomCarInCombobox()
        {
            string maker = SelectRandomElementsFromDropDown(MakeField);
            string model = SelectRandomElementsFromDropDown(ModelField);
            string year = SelectRandomElementsFromDropDown(YearField);
            return new Car(maker, model, year);
        }

        private static string SelectRandomElementsFromDropDown(By dropdown)
        {
            Random random = new Random();
            IComboBox drp = ElementFactory.GetComboBox(dropdown, "dropdown");
            drp.WaitAndClick();
            int randomInt = random.Next(1, drp.Values.Count());
            drp.SelectByIndex(randomInt);
            return drp.SelectedText;
        }
        public void ClickResearchButton()
        {
            ResearchButton.Click();
        }


    }
}
