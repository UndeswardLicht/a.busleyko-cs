using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using OpenQA.Selenium;

namespace ExampleProject.mytask
{
    internal class XPaths
    {
        //https://the-internet.herokuapp.com/add_remove_elements/
        private static readonly By headerAddRemoveElement = By.XPath("//*[contains(text(), 'Add/Remove')]");
        private static readonly By buttonAddElement = By.XPath("//button[@onclick='addElement()']");
        private static readonly By buttonDeleteElement = By.XPath("//button[@onclick='deleteElement()']");
        private static readonly By HrefElementinFooter = By.XPath("//*[@target='_blank']");

        //https://the-internet.herokuapp.com/tables
        private static readonly By headerDataTablesElement = By.XPath("//*[contains(text(), 'Data Tables')]");
        private static readonly By columnNamesTable1 = By.XPath("//table[@id='table1']//*[@class='header']");
        private static readonly By columnNamesTable2 = By.XPath("//table[@id='table2']//*[@class='header']");
        private static readonly By cellContainsJohnFromTable1 = By.XPath("//table[@id='table1']//*[contains(text(),'John')]");
        private static readonly By cellContainsEmailOfDoeFromTable2 = By.XPath("//table[@id='table2']//*[contains(text(),'Doe')]//following-sibling::td[@class='email']");

        //https://ru.wikipedia.org/
        private static readonly By headerWiki = By.XPath("//*[@class='main-top-header']");
        private static readonly By downloadAsPdfLink = By.XPath("//*[@id='coll-download-as-rl']");
        private static readonly By pictureFromSelectedArticle = By.XPath("(//*[@class='main-box-content'])[1]//figure");

        //https://ru.wikipedia.org/wiki/Шпаргалка
        private static readonly By exampleFromColumn = By.XPath("//*[@id='Обычный_текст']/ancestor::td//following-sibling::td");
        private static readonly By languageSettingsButton = By.XPath("//button[@class='uls-settings-trigger']");

        //https://ru.wikipedia.org/login
        private static readonly By loginField = By.XPath("//input[@id='wpName1']");
        private static readonly By loginFieldLabel = By.XPath("//label[@for='wpName1']");
        private static readonly By passwordField = By.XPath("//input[@id='wpPassword1']");
        private static readonly By passwordFieldLabel = By.XPath("//label[@for='wpPassword1']");
        private static readonly By rememberCheckbox = By.XPath("//input[@id='wpRemember']");
        private static readonly By loginButton = By.XPath("//button[@id='wpLoginAttempt']");
        private static readonly By loginHelpHref = By.XPath("//a[text()='Помощь по входу']/@href");
        private static readonly By resetPasswordHref = By.XPath("//a[text()='Сбросить ваш пароль?']/@href");
        private static readonly By joinProjectButton = By.XPath("//*[@id='mw-createaccount-join']");




    }
}
