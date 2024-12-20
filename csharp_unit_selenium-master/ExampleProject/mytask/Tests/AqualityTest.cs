using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.mytask.Models;
using ExampleProject.mytask.Pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace ExampleProject.mytask.Tests
{
    internal class AqualityTest : BaseAqualityTest
    {
        private CarsMainPage carsMainPage = new();
        private CarDescriptionPage carDescriptionPage = new();
        private ModelDescriptionPage modelDescriptionPage = new();
        private ResearchAndReviewsPage researchAndReviewsPage = new();
        private YourCarComparisonPage yourCarComparisonPage = new();
        private CompareCarsSideBySide compareCarsSideBySide = new();


        [Test]
        public void carsTest()
        {
            //1   Переход на сайт http://www.cars.com
            //    -> Открывается главная страница сайта
            ClassicAssert.IsTrue(carsMainPage.State.IsDisplayed);
            carsMainPage.ClickAcceptAllOnBanner();

            //2   Переходим на страницу "Research & reviews"
            //    ->Открывается страница "Research & reviews".
            carsMainPage.GoToReviews();
            ClassicAssert.IsTrue(researchAndReviewsPage.State.IsDisplayed);

            //3   Выполняем поиск по случайно выбранным характеристикам
            //    -> Значения успешно выбраны в combobox.После нажатия на кнопку Research
            //    открывается страница с описанием авто
            //4   Переходим к разделу Trims и выбираем базовый(первый) трим
            //    ->Открылась страница с характеристиками выбранной модификации

            Car carA = SelectCarWithExistingTrim();

            carDescriptionPage.SelectFirstTrim();
            ClassicAssert.IsTrue(modelDescriptionPage.State.IsDisplayed);

            //5   Запоминаем характеристики авто для последующего сравнения(характеристики: Engine, Seats и Door Count)
            carA = modelDescriptionPage.AddCarDetails(carA);

            //6   Переходим на главную страницу http://www.cars.com
            //    ->Открывается главная страница сайта
            modelDescriptionPage.GoToMain();
            ClassicAssert.IsTrue(carsMainPage.State.IsDisplayed);

            //7   Выполняем шаги 2 - 5 для еще одного набора данных для поиска
            //    ->Поиск и отображение информации об авто успешно производится; характеристики сохранены
            carsMainPage.GoToReviews();
            Car carB = SelectCarWithExistingTrim();
            carDescriptionPage.SelectFirstTrim();
            carDescriptionPage.GoToMain();

            //8   Возвращаемся на страницу "Research & reviews"
            //    ->Открылась страница "Research & reviews"
            carsMainPage.GoToReviews();
            ClassicAssert.IsTrue(researchAndReviewsPage.State.IsDisplayed);

            //9   В разделе Side - by - Side Comparisons переходим по кнопке(ссылке) Compare cars 
            //    -> Открылась страница для выбора авто для сравнения
            researchAndReviewsPage.ClickForComparison();
            ClassicAssert.IsTrue(compareCarsSideBySide.State.IsDisplayed);

            //10  Кликаем на Add car и выбираем модель, отобранную на шагах 2 - 5, и кликаем по кнопке Add car to comparison  
            //    -> Открылась страница c выбранным авто для сравнения
            //11  Используя Add car, добавляем к сравнению модель, полученную на шаге 7
            //    ->Модели успешно выбраны для сравнения

            compareCarsSideBySide.SelectFirstCar(carA);
            compareCarsSideBySide.SelectSecondCar(carB);

            compareCarsSideBySide.ClickSearchButton();
            ClassicAssert.IsTrue(yourCarComparisonPage.State.IsDisplayed);


            //12  Кликаем по кнопке See the comparison и проверяем страницу сравнения 2 - ух моделей
            //    ->Характеристики авто на странице соответствуют тем, что получены на шагах 2 - 7
            ClassicAssert.IsTrue(yourCarComparisonPage.retrievePriceFirstCar().Equals(carA.Price));
            ClassicAssert.IsTrue(yourCarComparisonPage.retrievePriceSecondCar().Equals(carB.Price));

        }
        public Car SelectCarWithExistingTrim()
                {
                    Car car = researchAndReviewsPage.SelectCarInCombobox();
                    researchAndReviewsPage.ClickResearchButton();
                    if (carDescriptionPage.CheckTrims())
                    {
                        return car;
                    };
                    carDescriptionPage.GoToReviews();
                    return SelectCarWithExistingTrim();

                }
    }
}
