using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace ExampleProject.mytask.Tests
{
    internal class CookieTest : BaseCookieTest

    {
        private By uniqueElement = By.XPath("//h1[contains(text(), 'Example Domain')]");

        [Test]
        public void CookiesTest()
        {
            //1. Зайти на ресурс: http://example.com/ -> Форма сайта открылась 
            ClassicAssert.IsTrue(driver.FindElement(uniqueElement).Displayed);

            //2. Добавить три cookie:               ->  cookie добавлены
            //        example_key_1: example_value_1
            //        example_key_2:example_value_2
            //        example_key_3:example_value_3
            Cookie cookieA = new Cookie("example_key_1", "example_value_1");
            Cookie cookieB = new Cookie("example_key_2", "example_value_2");
            Cookie cookieC = new Cookie("example_key_3", "example_value_3");
            
            driver.Manage().Cookies.AddCookie(cookieA);
            driver.Manage().Cookies.AddCookie(cookieB);
            driver.Manage().Cookies.AddCookie(cookieC);

            Cookie cookieX = driver.Manage().Cookies.GetCookieNamed("example_key_1");
            Cookie cookieY = driver.Manage().Cookies.GetCookieNamed("example_key_2");
            Cookie cookieZ = driver.Manage().Cookies.GetCookieNamed("example_key_3");

            ClassicAssert.IsTrue(cookieX.Equals(cookieA));
            ClassicAssert.IsTrue(cookieY.Equals(cookieB));
            ClassicAssert.IsTrue(cookieZ.Equals(cookieC));

            //3   Удалить cookie с ключом example_key_1  -> cookie с ключом example_key_1 удален

            driver.Manage().Cookies.DeleteCookieNamed("example_key_1");
            ClassicAssert.IsNull(driver.Manage().Cookies.GetCookieNamed("example_key_1"));


            //4   Для cookie с ключом example_key_3
            //добавить значение example_value_300    -> Проверить, что cookie с ключом example_key_3 принял новое значение
            driver.Manage().Cookies.AddCookie(new Cookie("example_key_3", "example_value_300"));
            ClassicAssert.IsTrue(
                driver.Manage().Cookies.GetCookieNamed("example_key_3")
                .Value.Equals("example_value_300"));

            //5   Удалить все cookie                ->  Проверить, что cookie удалены
            driver.Manage().Cookies.DeleteAllCookies();
            var cookies = driver.Manage().Cookies.AllCookies;
            ClassicAssert.IsEmpty(cookies);
        }
    }
}
