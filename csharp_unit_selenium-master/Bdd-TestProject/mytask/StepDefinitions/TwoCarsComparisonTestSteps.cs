using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework.Legacy;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    //todo test steps to be separated into different files depending on page
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
       
        public void SelectTheVeryFirstTrimOfCar(Car car)
        {
            carsMainPage.GoToReviews();
            researchAndReviewsPage.SelectSpecificCarInCombobox(car);
            carDescriptionPage.SelectFirstTrim();
        }

        //todo modify those two or merge them two into one somehow 
        public void RememberThePriceOfTheTrimOfCarA()
        {
           priceOfCarA = modelDescriptionPage.GetPriceOfThisCar();
        }

        public void RememberThePriceOfTheTrimOfCarB()
        {
            priceOfCarB = modelDescriptionPage.GetPriceOfThisCar();
        }

        public void GoFromMainToReviewsPage()
        {
            carsMainPage.GoToReviews();
        }

        public void ResearchPageIsDisplayed()
        {
            ClassicAssert.IsTrue(researchAndReviewsPage.State.IsDisplayed);
        }

        public void GoFromResearchToComparePage()
        {
            researchAndReviewsPage.ClickForComparison();
        }

        public void CompareSideBySideIsDisplayed()
        {
            ClassicAssert.IsTrue(compareCarsSideBySide.State.IsDisplayed);
        }

        //todo add specific cars as parameter
        public void SelectCarInSideBySideComparisonBox(Car car, string whichCar)
        {
            compareCarsSideBySide.SelectCar(car, whichCar);
        }

        public void ClickCompareSideBySideButton()
        {
            compareCarsSideBySide.ClickSearchButton();
        }

        public void CarComparisonPageIsDisplayed()
        {
            ClassicAssert.IsTrue(yourCarComparisonPage.State.IsDisplayed);
        }

        //todo add specific cars as parameter
        //todo re-do as it's currently works with one pre-set variable - price of car A
        public void PriceOfCarIsTheSame(string whichCar)
        {
            ClassicAssert.IsTrue(yourCarComparisonPage.retrieveCarPrice(whichCar).Equals(priceOfCarA));
            ClassicAssert.IsTrue(yourCarComparisonPage.retrieveCarPrice(whichCar).Equals(priceOfCarB));
        }

    }
}
