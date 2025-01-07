using Aquality.Selenium.Elements.Interfaces;
using Bdd_TestProject.mytask.Pages;
using ExampleProject.mytask.Models;
using OpenQA.Selenium;

namespace ExampleProject.mytask.Pages
{
    internal class CompareCarsSideBySide : BaseForm
    {
        private string MakerPath = "//*[@data-qa='make-selector-vehicle_']";
        private string ModelPath= "//*[@data-qa='model-selector-vehicle_']";
        private string YearPath = "//*[@data-qa='year-selector-vehicle_']";

        private IButton SeeComparisonButton = ElementFactory.GetButton(
            By.XPath("//spark-button[contains(text(), 'See the comparison')]"), "See comparison button");
        private ILabel specificElementLabel(string value, string whichCar) => ElementFactory.GetLabel(
            By.XPath($"(*//option[contains(text(), '{value}')])[{whichCar}]"), "label");
        private ILabel dropdownLabel(string path, string whichDropdown,string whichCar) =>
            ElementFactory.GetLabel(
                By.XPath(path.Insert(path.Length-2, whichCar)), $"{whichDropdown} dropdown of the {whichCar}, its XPATH: {path.Insert(path.Length - 2, whichCar)}");
        public CompareCarsSideBySide() : base(By.XPath("//h1[contains(text(), 'Compare cars')]"), "Compare cars side by side")
        {   
        }

        public void SelectMakerInDropdown(string maker, string whichCar)
        {
            dropdownLabel(MakerPath, "maker", whichCar).ClickAndWait();
            specificElementLabel(maker, whichCar).ClickAndWait();
        }

        public void SelectModelInDropdown(string model, string whichCar)
        {

            dropdownLabel(ModelPath, "model", whichCar).
                ClickAndWait();
            specificElementLabel(model, whichCar).ClickAndWait();
        }
        public void SelectYearInDropdown(string year, string whichCar)
        {
            dropdownLabel(YearPath, "year", whichCar).ClickAndWait();
            specificElementLabel(year, whichCar).ClickAndWait();
        }
        public void ClickSearchButton()
        {
            SeeComparisonButton.Click();

        }

    }
}
