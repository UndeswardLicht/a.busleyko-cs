using System;
using System.Collections.Generic;
using System.Linq;
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
        //todo change
        private static By UniqeElement = By.XPath(string.Format(LocatorConstants.PreciseClassLocator, "comparison-box"));
        private IComboBox MakeFieldFirstCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='make-selector-vehicle_1']"), "first car maker dropdown");
        private IComboBox ModelFieldFirstCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='model-selector-vehicle_1']"), "first car model dropdown");
        private IComboBox YearFieldFirstCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='year-selector-vehicle_1']"), "first car year dropdown");
        private IComboBox MakeFieldSecondCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='make-selector-vehicle_2']"), "second car maker dropdown");
        private IComboBox ModelFieldSecondCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='model-selector-vehicle_2']"), "second car model dropdown");
        private IComboBox YearFieldSecondCar = ElementFactory.GetComboBox(By.XPath("//*[@data-qa='year-selector-vehicle_2']"), "second car year dropdown");
        private IButton SeeComparisonButton = ElementFactory.GetButton(By.XPath("//spark-button[contains(text(), 'See the comparison')]"), "See comparison button");
        //private IComboBox dropdown = ElementFactory.GetComboBox(MakeFieldFirstCar, "label");

        public CompareCarsSideBySide() : base(UniqeElement, PageName)
        {   
        }
        //those methods get Car and select values from dropdown in combobox acc to the object fields
        public void SelectFirstCar(Car car)
        {
            MakeFieldFirstCar.SelectByText(car.Maker);
            ModelFieldFirstCar.SelectByText(car.Model);
            YearFieldFirstCar.SelectByText(car.Year);
        }
        public void SelectSecondCar(Car car)
        {
            MakeFieldSecondCar.SelectByText(car.Maker);
            ModelFieldSecondCar.SelectByText(car.Model);
            YearFieldSecondCar.SelectByText(car.Year);
        }

        //public void SelectValueFromDropDown(string value)
        //{
        //    dropdown.SelectByText(value);
        //}

        public void ClickSearchButton()
        {
            SeeComparisonButton.Click();
        }

        //TODO Wrong method as we need to compare not random but already selected cars!
        //private static string SelectElementsFromDropDown(By dropdown)
        //{
        //    IList<Element> list = ElementFactory.FindElements<Element>(dropdown);
        //    Random random = new Random();
        //    //starting from 2 because on 1st place is "All models" or smth like this
        //    int randomInt = random.Next(2, list.Count() + 1);
        //    return list[randomInt].GetElement().GetAttribute("value");
        //}


    }
}
