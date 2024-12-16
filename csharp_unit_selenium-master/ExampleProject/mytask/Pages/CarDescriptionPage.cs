using System;
using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using System.Reflection.Metadata;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class CarDescriptionPage : AQF.Form
    {
        //TODO check which modifiers are correct
        private const string PageName = "Selected car page";
        private const string UniqeElement = "Change year or car";
        private static readonly By FirstTrim = By.XPath("//*[@data-linkname='research-mmyt']");
        private ILink FirstTrimLink = ElementFactory.GetLink(FirstTrim, "The very first trim");
        

        //TODO how this constructior works?....
        public CarDescriptionPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, UniqeElement)), PageName)
        {
        }

        public void SelectFirstTrim()
        {
            //TODO how to handle situation if cannot find trim?
            FirstTrimLink.Click();
        }
    }
}
