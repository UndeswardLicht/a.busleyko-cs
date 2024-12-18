using System;

using AQF = Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Constants;

namespace ExampleProject.mytask.Pages
{
    internal class CarsMainPage : AQF.Form
    {
        private const string PageName = "Cars - Main Page";
        private const string uniqueElement = "Popular categories";
        private ILink reviewsPageLink = ElementFactory.GetLink(By.XPath(
            "//header//*[@data-linkname = 'header-research']"), "Link to go to Research & Reviews page"); 

        //private ILink navigationLink(string navigation) => ElementFactory.GetLink(
        //    By.XPath(string.Format(LocatorConstants.PreciseTextLocator, navigation)), "Navigation link");

        public CarsMainPage() : base(By.XPath(string.Format(LocatorConstants.PartialTextLocator, uniqueElement)), PageName)
        {
        }

        //public void ClickNavigationLink(string navigationName)
        //{
        //    navigationLink(navigationName).Click();
        //}

        public void GoToReviews()
        {
            reviewsPageLink.Click();
        }


    }
}
