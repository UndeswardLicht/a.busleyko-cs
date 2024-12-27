using System;
using System.Linq;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using Bdd_TestProject.mytask.Pages;
using System.Runtime.ConstrainedExecution;

namespace ExampleProject.mytask.Pages
{
    internal class ResearchAndReviewsPage : BaseForm
    {
        private IButton ResearchButton = ElementFactory.GetButton(
            By.XPath("//*[@id='panel-2']//spark-button"), "Research button");
        private ILink SideBySideComparisonLink = ElementFactory.GetLink(
            By.XPath("//*[@data-linkname='research-compare']"), "Side-By-Side Comparison");
        private static By MakeField = By.XPath("//*[@id='make-select']");
        private static By ModelField = By.XPath("//*[@id='model-select']");
        private static By YearField = By.XPath("//*[@id='year-select']");
        ILabel makeCar = ElementFactory.GetLabel(MakeField, "maker dropdown of the car");
        ILabel modelCar = ElementFactory.GetLabel(ModelField, "model dropdown of the car");
        ILabel yearCar = ElementFactory.GetLabel(YearField, "year dropdown of the car");
        private ILabel label(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "label");

        public ResearchAndReviewsPage() : base(By.XPath("//*[text()='Research & Reviews']"), "Research & Reviews")
        {
        }

        public void ClickForComparison()
        {
            SideBySideComparisonLink.Click();
        }

        //Next methods select from dropdown a specific car either by string or by object
        //provided as an argument and return nothing
        public void SelectSpecificCarInCombobox(Car car)
        {

            makeCar.ClickAndWait();
            label(car.Maker).ClickAndWait();
            modelCar.ClickAndWait();
            label(car.Model).ClickAndWait();
            yearCar.ClickAndWait();
            label(car.Year).ClickAndWait();
        }

        public void SelectSpecificMakerInCombobox(string maker)
        {
            makeCar.ClickAndWait();
            label(maker).ClickAndWait();
        }
        public void SelectSpecificModelInCombobox(string model)
        {
            modelCar.ClickAndWait();
            label(model).ClickAndWait();
        }
        
        public void SelectSpecificYearInCombobox(string year)
        {
            yearCar.ClickAndWait();
            label(year).ClickAndWait();
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
