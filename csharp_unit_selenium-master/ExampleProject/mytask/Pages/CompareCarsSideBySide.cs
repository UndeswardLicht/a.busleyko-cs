using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Constants;
using ExampleProject.mytask.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.Overlay;
using OpenQA.Selenium.Support.UI;
using AQF = Aquality.Selenium.Forms;

namespace ExampleProject.mytask.Pages
{
    internal class CompareCarsSideBySide : AQF.Form
    {
        private const string PageName = "Compare cars side by side";
        private static By UniqeElement = By.XPath("//h1[contains(text(), 'Compare cars')]");
        private IComboBox MakeFieldFirstCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='make-selector-vehicle_1']"), "first car maker dropdown");
        private IComboBox ModelFieldFirstCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='model-selector-vehicle_1']"), "first car model dropdown");
        private IComboBox YearFieldFirstCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='year-selector-vehicle_1']"), "first car year dropdown");
        private IComboBox MakeFieldSecondCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='make-selector-vehicle_2']"), "second car maker dropdown");
        private IComboBox ModelFieldSecondCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='model-selector-vehicle_2']"), "second car model dropdown");
        private IComboBox YearFieldSecondCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='year-selector-vehicle_2']"), "second car year dropdown");
        private IButton SeeComparisonButton = ElementFactory.GetButton(By.XPath("//spark-button[contains(text(), 'See the comparison')]"), "See comparison button");
        private ILabel label(string value) => ElementFactory.GetLabel(By.XPath($"//option[contains(text(), '{value}')]"), "label");
        public CompareCarsSideBySide() : base(UniqeElement, PageName)
        {   
        }
        public void SelectFirstCar(Car car)
        {
            MakeFieldFirstCar.ClickAndWait();
            label(car.Maker).ClickAndWait();
            ModelFieldFirstCar.ClickAndWait();
            label(car.Model).ClickAndWait();
            YearFieldFirstCar.ClickAndWait();
            label(car.Year).ClickAndWait();
        }
        public void SelectSecondCar(Car car)
        {
            MakeFieldSecondCar.ClickAndWait();
            label(car.Maker).ClickAndWait();
            ModelFieldSecondCar.ClickAndWait();
            label(car.Model).ClickAndWait();
            YearFieldSecondCar.ClickAndWait();
            label(car.Year).ClickAndWait();
        }

        public void ClickSearchButton()
        {
            SeeComparisonButton.Click();

        }

    }
}
