using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{
    internal class CarsMainPage : BaseForm
    {
        public CarsMainPage() : base(By.XPath("//*[contains(text(),'Popular categories')]"), "Cars - Main Page")
        {
        }

    }
}
