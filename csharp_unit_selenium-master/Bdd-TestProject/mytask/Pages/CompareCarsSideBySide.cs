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
        private ILabel specificElementLabel(string value) => ElementFactory.GetLabel(
            By.XPath($"//option[contains(text(), '{value}')]"), "label");

        private ILabel dropdownLabel(string path, string whichDropdown,string whichCar) =>
            ElementFactory.GetLabel(
                By.XPath(path.Insert(path.Length-2, whichCar)), $"{whichDropdown} dropdown of the {whichCar}");
        public CompareCarsSideBySide() : base(By.XPath("//h1[contains(text(), 'Compare cars')]"), "Compare cars side by side")
        {   
        }

        public void SelectMakerInDropdown(string maker, string whichCar)
        {
            dropdownLabel(MakerPath, "maker", whichCar).ClickAndWait();
            specificElementLabel(maker).ClickAndWait();
        }

        public void SelectModelInDropdown(string model, string whichCar)
        {
            dropdownLabel(ModelPath, "model", whichCar).ClickAndWait();
            specificElementLabel(model).ClickAndWait();
        }
        public void SelectYearInDropdown(string year, string whichCar)
        {
            dropdownLabel(YearPath, "year", whichCar).ClickAndWait();
            specificElementLabel(year).ClickAndWait();
        }

        public void SelectCar(Car car, string whichCar)
        {

            dropdownLabel(MakerPath, "maker", whichCar).ClickAndWait();
            specificElementLabel(car.Maker).ClickAndWait();
            dropdownLabel(ModelPath, "model", whichCar).ClickAndWait();
            specificElementLabel(car.Model).ClickAndWait();
            dropdownLabel(YearPath, "year", whichCar).ClickAndWait();
            specificElementLabel(car.Year).ClickAndWait();
        }
        public void ClickSearchButton()
        {
            SeeComparisonButton.Click();

        }

    }
}
