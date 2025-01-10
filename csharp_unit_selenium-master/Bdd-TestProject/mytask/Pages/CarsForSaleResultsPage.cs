using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{

    internal class CarsForSaleResultsPage : BaseForm
    {
        private ILabel noCarsFoundLabel = ElementFactory.GetLabel(
            By.XPath("//*[contains(@class, 'total-filter-count') and contains(text(), '0 matches')]"), "nothing found label");
        private ILabel MinYearLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='year_year_min_select']"), "min year label");
        private ILabel MaxYearLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='year_year_max_select']"), "max year label");
        private ILabel yearLabel(string value) => ElementFactory.GetLabel(
            By.XPath($"//option[contains(text(), '{value}')]"), "year label");

        private ICheckBox trimCheckBox(string value) => ElementFactory.GetCheckBox(
            By.XPath($"//*[@id='trim']//*[contains(text(), '{value}')]//preceding-sibling::input"), "trim chckbox");
        private ILabel trimLabel(string value) => ElementFactory.GetLabel(
            By.XPath($"//*[@class='sds-checkbox']//*[contains(text(), '{value}')]"), "trim chckbox");

        private ILabel priceOfFirstFoundCar = ElementFactory.GetLabel(
            By.XPath("(//*[@data-qa='primary-price'])[1]"), "price of the first found car label");
        
        public CarsForSaleResultsPage() : base(By.XPath("//li[contains(text(), 'Cars for Sale')]"), "Cars for sale - results page")
        {
        }
        public void SelectMinYear(string minYear)
        {
            MinYearLabel.ClickAndWait();
            yearLabel(minYear).ClickAndWait();
        }

        public void SelectMaxYear(string maxYear)
        {
            MaxYearLabel.ClickAndWait();
            yearLabel(maxYear).ClickAndWait();
        }

        public void SelectSameTrim(string value)
        {
            trimLabel(value).JsActions.Click();
        }

        public bool IsSomethingFound()
        {
            return !noCarsFoundLabel.State.IsDisplayed;
        }

        public float RetrieveFirstFoundCarPrice()
        {
            string s = priceOfFirstFoundCar.GetText().Trim('$');
            return Single.Parse(s);
        }

        public bool IsFoundCarCheaper(float foundCar, float savedCar)
        {
            return foundCar < savedCar;
        }
    }
}
