using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace ExampleProject.Selenium
{
    internal class DynamicControlsTests : BaseTest
    {
        private static readonly By dynamicControl = By.XPath(string.Format(preciseTextXpath, "Dynamic Controls"));
        private static readonly By enableBtn = By.XPath(string.Format(preciseTextXpath, "Enable"));
        private static readonly By inputfField = By.XPath("//*[@id='input-example']//input");
        private static readonly string randomValue = Guid.NewGuid().ToString();


        [Test]
        public void DynamicControlsTest()
        {
            driver.FindElement(dynamicControl).Click();
            driver.FindElement(enableBtn).Click();
            var inputFieldElement = driver.FindElement(inputfField);
            Assert.That(isEnabled(inputFieldElement), Is.True, "input is not enabled");
            inputFieldElement.SendKeys(randomValue);
            Assert.That(driver.FindElement(inputfField).GetAttribute("value"), Is.EqualTo(randomValue),
                "Text is not displayed");
        }

        private bool isEnabled(IWebElement webElement)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
            }
            catch (TimeoutException)
            {
                return false;
            }
            return true;
        }
    }
}
