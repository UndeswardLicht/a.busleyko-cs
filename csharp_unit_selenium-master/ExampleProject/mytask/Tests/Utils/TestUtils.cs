using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;

namespace ExampleProject.mytask.Tests.Utils
{
    internal class TestUtils
    {
        public static Car SelectCarWithExistingTrim(ResearchAndReviewsPage rrp, CarDescriptionPage cdp)
        {
            Car car = rrp.SelectCarInCombobox();
            rrp.ClickResearchButton();
            if (cdp.CheckTrims())
            {
                return car;
            };
            cdp.GoToReviews();
            return SelectCarWithExistingTrim(rrp, cdp);

        }
    }
}
