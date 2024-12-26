using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    //todo should test steps be separated into different files depending on the page?
    internal class TwoCarsComparisonTestSteps
    {
        private CarsMainPage carsMainPage = new();
        private CarDescriptionPage carDescriptionPage = new();
        private ModelDescriptionPage modelDescriptionPage = new();
        private ResearchAndReviewsPage researchAndReviewsPage = new();
        private YourCarComparisonPage yourCarComparisonPage = new();
        private CompareCarsSideBySide compareCarsSideBySide = new();
        private string priceOfCarA;
        private string priceOfCarB;
        /*Scenario Outline: Trim is selected
        Given I am on the the Main Page
        When I go to the Research & Reviews page
        Then Research & Reviews page is displayed
        When I enter<maker> for a car
        And I enter<model> for a car
        And I enter<year> for a car
        And I click Research button
        Then the Car Description Page is displayed
        When I go to the Trims section

        And I select the very first trim
        Then the Model Description Page is displayed
        And I remember the characteristics (Price) of the selected model
        Examples: 
                | maker | model | year |
                | FIAT  | 500   | 2012 |
                | BMW   | 128   | 2013 |

    */

       
        //todo add specific cars as parameter
        [Given(@"an existing very first trim of car A  is selected")]
        [Given(@"an existing very first trim of car B is selected")]
        public void SelectTheVeryFirstTrimOfCar(Car car)
        {
            carsMainPage.GoToReviews();
            researchAndReviewsPage.SelectSpecificCarInCombobox(car);
            carDescriptionPage.SelectFirstTrim();
        }

        //todo modify those two or merge them two into one somehow 
        [Given("the price of the very first trim of car A is remembered")]
        public void RememberThePriceOfTheTrimOfCarA()
        {
           priceOfCarA = modelDescriptionPage.GetPriceOfThisCar();
        }

        [Given("the price of the very first trim of car B is remembered")]
        public void RememberThePriceOfTheTrimOfCarB()
        {
            priceOfCarB = modelDescriptionPage.GetPriceOfThisCar();
        }

        [Given(@"I am on the the Main page and I go to the Research & Reviews page")]
        public void GoFromMainToReviewsPage()
        {
            carsMainPage.GoToReviews();
        }

        [Then(@"Research & Reviews page is displayed")]
        public void ResearchPageIsDisplayed()
        {
            ClassicAssert.IsTrue(researchAndReviewsPage.State.IsDisplayed);
        }

        [When(@"I go click 'Compare cars' in 'Side-by-Side Comparisons' section")]
        public void GoFromResearchToComparePage()
        {
            researchAndReviewsPage.ClickForComparison();
        }

        [Then(@"the Side-By-Side Comparison page is displayed")]
        public void CompareSideBySideIsDisplayed()
        {
            ClassicAssert.IsTrue(compareCarsSideBySide.State.IsDisplayed);
        }

        //todo add specific cars as parameter
        [When("I select car A in the first box")]
        [When("I select car B in the second box")]
        public void SelectCarInSideBySideComparisonBox(Car car, string whichCar)
        {
            compareCarsSideBySide.SelectCar(car, whichCar);
        }

        [When("I click 'Compare cars' button")]
        public void ClickCompareSideBySideButton()
        {
            compareCarsSideBySide.ClickSearchButton();
        }

        [Then(@"Your Car comparison page is displayed")]
        public void CarComparisonPageIsDisplayed()
        {
            ClassicAssert.IsTrue(yourCarComparisonPage.State.IsDisplayed);
        }

        //todo add specific cars as parameter
        //todo re-do as it's currently works with one pre-set variable - price of car A
        [Then(@"Price of car A is the same as remembered")]
        [Then(@"Price of car B is the same as remembered")]
        public void PriceOfCarIsTheSame(string whichCar)
        {
            ClassicAssert.IsTrue(yourCarComparisonPage.retrieveCarPrice(whichCar).Equals(priceOfCarA));
            ClassicAssert.IsTrue(yourCarComparisonPage.retrieveCarPrice(whichCar).Equals(priceOfCarB));
        }

    }
}
