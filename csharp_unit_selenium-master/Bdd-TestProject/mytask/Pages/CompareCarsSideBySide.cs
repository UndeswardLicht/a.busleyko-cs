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
        private IButton SeeComparisonButton = ElementFactory.GetButton(By.XPath("//spark-button[contains(text(), 'See the comparison')]"), "See comparison button");
        private ILabel label(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "label");
        public CompareCarsSideBySide() : base(By.XPath("//h1[contains(text(), 'Compare cars')]"), "Compare cars side by side")
        {   
        }

        //TODO remove initialization of labels ffrom methods to the class
        public void SelectMakerInDropdown(string maker, string whichCar)
        {
            ILabel makeCar = ElementFactory.GetLabel(
    By.XPath(MakerPath.Insert(MakerPath.Length - 2, whichCar)), $"maker dropdown of the {whichCar} car");
            makeCar.ClickAndWait();
            label(maker).ClickAndWait();
        }

        public void SelectModelInDropdown(string model, string whichCar)
        {
            ILabel modelCar = ElementFactory.GetLabel(
                By.XPath(ModelPath.Insert(ModelPath.Length - 2, whichCar)), $"model dropdown of the {whichCar} car");
            modelCar.ClickAndWait();
            label(model).ClickAndWait();
        }
        public void SelectYearInDropdown(string year, string whichCar)
        {
            ILabel yearCar = ElementFactory.GetLabel(
               By.XPath(YearPath.Insert(YearPath.Length - 2, whichCar)), $"year dropdown of the {whichCar} car");
            yearCar.ClickAndWait();
            label(year).ClickAndWait();
        }

        public void SelectCar(Car car, string whichCar)
        {
            ILabel makeCar = ElementFactory.GetLabel(
                By.XPath(MakerPath.Insert(MakerPath.Length - 2, whichCar)), $"maker dropdown of the {whichCar} car");
            ILabel modelCar = ElementFactory.GetLabel(
                By.XPath(ModelPath.Insert(ModelPath.Length - 2, whichCar)), $"model dropdown of the {whichCar} car");
            ILabel yearCar = ElementFactory.GetLabel(
                By.XPath(YearPath.Insert(YearPath.Length - 2, whichCar)), $"year dropdown of the {whichCar} car");
            
            makeCar.ClickAndWait();
            label(car.Maker).ClickAndWait();
            modelCar.ClickAndWait();
            label(car.Model).ClickAndWait();
            yearCar.ClickAndWait();
            label(car.Year).ClickAndWait();
        }
        public void ClickSearchButton()
        {
            SeeComparisonButton.Click();

        }

    }
}
