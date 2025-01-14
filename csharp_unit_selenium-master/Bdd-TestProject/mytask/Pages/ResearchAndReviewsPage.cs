using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using Bdd_TestProject.mytask.Models;

namespace Bdd_TestProject.mytask.Pages
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
        private ILabel label(string value) => ElementFactory.GetLabel(
            By.XPath($"//option[contains(text(), '{value}')]"), "label");

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

        public void ClickResearchButton()
        {
            ResearchButton.Click();
        }


    }
}
