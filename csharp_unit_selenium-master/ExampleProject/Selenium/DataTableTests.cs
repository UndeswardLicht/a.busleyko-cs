using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class DataTableTests : BaseTest
    {
        private static readonly By sortableDataTables = By.XPath(string.Format(preciseTextXpath, "Sortable Data Tables"));
        private static readonly By dueColumn = By.XPath("//*[@id='table1']//td[4]");
        private static readonly double expectedSum = 251.00;
        private static readonly string currencyRegex = "[^\\d.]";


        [Test]
        public void DataTableTest()
        {
            driver.FindElement(sortableDataTables).Click();
            var dueListElements = driver.FindElements(dueColumn);
            double actualSum = 0.00;
            foreach(WebElement e in dueListElements)
            {
               actualSum +=  Convert.ToDouble(Regex.Replace(e.Text, currencyRegex, "").Replace(".", ","));
            }
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }
    }
}
