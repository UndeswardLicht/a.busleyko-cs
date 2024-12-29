using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Elements;
using OpenQA.Selenium;
using Bdd_TestProject.mytask.Pages;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class BaseSteps
    {
        BaseForm baseForm = new();

        [When("I go back to Main page")]
        public void GoToMain()
        {
            baseForm.GoToMain();
        }

        [When("I go to Research & Reviews page")]
        public void GoToReviews()
        {
            baseForm.GoToResearchAndReviews();
        }

        [When("I go to Cars for Sale page")]
        public void GoToCarsForSale()
        {
            baseForm.GoToCarsForSale();
        }
    }
}
