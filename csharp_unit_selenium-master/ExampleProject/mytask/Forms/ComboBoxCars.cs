using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium.Core.Elements;
using OpenQA.Selenium;
using AQE = Aquality.Selenium.Elements;

namespace ExampleProject.mytask.Forms
{
    //TODO should be impl of IComboBox from collection? + additional methods
    //and some PageObjects should use this int
    internal class ComboBoxCars : AQE.ComboBox
    {
        protected internal ComboBoxCars(By locator, string name, ElementState state) : base(locator, name, state)
        {
        }
    }
}
