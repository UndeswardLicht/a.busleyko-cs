using System;
using System.Collections.Generic;
using System.Linq;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Constants;
using ExampleProject.mytask.Models;
using OpenQA.Selenium;
using AQF = Aquality.Selenium.Forms;

namespace ExampleProject.mytask.Pages
{
    internal class CompareCarsSideBySide : AQF.Form
    {
        private const string PageName = "Compare cars side by side";
        //TODO unique element is a box, not text?
        private static By UniqeElement = By.XPath(string.Format(LocatorConstants.PreciseClassLocator, "comparison-box"));
        private By MakeFieldFirstCar = By.XPath("(//*[@id='vehicle_picker_make'])[1]");
        private By ModelFieldFirstCar = By.XPath("(//*[@id='vehicle_picker_model'])[1]");
        private By YearFieldFirstCar = By.XPath("(//*[@id='vehicle_picker_year'])[1]");
        private By MakeFieldSecondCar = By.XPath("(//*[@id='vehicle_picker_make'])[2]");
        private By ModelFieldSecondCar = By.XPath("(//*[@id='vehicle_picker_model'])[2]");
        private By YearFieldSecondCar = By.XPath("(//*[@id='vehicle_picker_year'])[2]");
        private IButton SeeComparisonButton = ElementFactory.GetButton(By.XPath("//spark-button[contains(text(), 'See the comparison')]"), "See comparison button");
        public CompareCarsSideBySide() : base(UniqeElement, PageName)
        {   
        }

        public Car SelectFirstCar()
        {
            return null;
        }
        public Car SelectSecondCar()
        {
            return null;
        }

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


        //method gets Car and selects values from dropdown in combobox acc to the object fields
        private void SelectCarFromDropDown(Car someCar)
        {

           
        }
    }
}
