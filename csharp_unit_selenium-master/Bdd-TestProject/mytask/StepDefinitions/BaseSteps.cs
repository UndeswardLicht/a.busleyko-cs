using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Elements;
using OpenQA.Selenium;
using Bdd_TestProject.mytask.Pages;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    //universal methods same for diff pages (header) -> to be parent
    internal class BaseSteps
    {
        BaseForm baseForm = new();
       
        public void GoToMain()
        {
            baseForm.GoToMain();
        }

        public void GoToReviews()
        {
            baseForm.GoToResearchAndReviews();
        }

        public void GoToCarsForSale()
        {
            baseForm.GoToCarsForSale();
        }
    }
}
