using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Bdd_TestProject.mytask.Pages
{

    internal class CarsForSaleResultsPage : BaseForm
    {
        private ILabel noCarsFoundLabel = ElementFactory.GetLabel(
            By.XPath("//h3//*[contains(text(), 'No exact matches found')]"), "nothing found label");
        private ILabel MinYearLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='year_year_min_select']"), "min year label");
        private ILabel MaxYearLabel = ElementFactory.GetLabel(
            By.XPath("//*[@id='year_year_max_select']"), "max year label");
        private ILabel yearLabel(string value) => ElementFactory.GetLabel(
            By.XPath($"//option[contains(text(), '{value}')]"), "year label");
        private ICheckBox trimCheckBox(string value) => ElementFactory.GetCheckBox(
            By.XPath($"//*[@id='trim']//*[contains(text(), '{value}')]//preceding-sibling::input"), "trim chckbox");
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
            trimCheckBox(value).Check();
        }

        public bool IsSomethingFound()
        {
            return !noCarsFoundLabel.State.IsDisplayed;
        }

        public int RetrieveFirstFoundCarPrice()
        {
            int.TryParse(priceOfFirstFoundCar.GetText().Trim('$'), out int price);
            return price;
        }

        public bool IsFoundCarCheaper(int foundCar, int savedCar)
        {
            return foundCar < savedCar;
        }
    }
}
