using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;
using Bdd_TestProject.mytask.Pages;

namespace ExampleProject.mytask.Pages
{
    internal class CarsMainPage : BaseForm
    {
        public CarsMainPage() : base(By.XPath("//*[contains(text(),'Popular categories')]"), "Cars - Main Page")
        {
        }

    }
}
