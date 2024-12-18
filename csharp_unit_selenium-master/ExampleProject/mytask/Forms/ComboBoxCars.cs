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

    //TODO change
    //can be used one locator for comboBox on every page? if yes:
    //AQ.Form -> inh and create BaseForm (at this stage you can impl ComboBox on this site) -> inh create PageForm -> inh and create Pages
    internal class ComboBoxCars : AQE.ComboBox
    {
        protected internal ComboBoxCars(By locator, string name, ElementState state) : base(locator, name, state)
        {
        }

        //todo add methos selcting cars
    }
}
