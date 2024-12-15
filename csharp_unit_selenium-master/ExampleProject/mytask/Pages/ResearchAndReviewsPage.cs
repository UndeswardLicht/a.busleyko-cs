using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQF = Aquality.Selenium.Forms;
using AQEI = Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Interfaces;

namespace ExampleProject.mytask.Pages
{
    internal class ResearchAndReviewsPage : AQF.Form
    {
        private const string PageName = "Research & Reviews";
        private By SideBySide = By.XPath("//*[@data-linkname='research-compare']");
        private By Combobox = By.XPath(string.Format(LocatorConstants.PreciseClassLocator, "sds-field-group field-group-melded"));
        private IButton ResearchButton = ElementFactory.GetButton(By.XPath(string.Format(
            LocatorConstants.PreciseClassLocator, "sds-field-group field-group-melded")), "Research button");


        public ResearchAndReviewsPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void ClickForComparison()
        {
            ILink link = ElementFactory.GetLink(SideBySide, "Side-By-Side Comparison");
            link.Click();
        }

        //TODO add three fields from combobox and make them to build car
        public Car SelectCarInCombobox()
        {
            return null;
        }

        public void ClickResearchButton()
        {
            ResearchButton.Click();
        }
    }
}
