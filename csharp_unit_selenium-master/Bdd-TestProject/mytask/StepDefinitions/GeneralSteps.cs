using System.Runtime.InteropServices;
using Bdd_TestProject.mytask.Models;
using ExampleProject.mytask.Models;
using TechTalk.SpecFlow;

namespace Bdd_TestProject.mytask.StepDefinitions
{
    [Binding]
    internal class GeneralSteps
    {
        [When(@"I create '(.*)' with values '(.*)', '(.*)', '(.*)' to store data of a Car")]
        public void CreateCarObjectWithParameters(string someCar, string maker, string model, string year)
        {
            Car car = new Car(maker, model, year);
            Store.Put($"{someCar}", ref car);
        }

        [When ("I create '(.*)' to store Car object there")]
        public void CreateCarObjectwithoutParameters(string someCar)
        {
            Car car = new Car();
            Store.Put($"{someCar}", ref car);
        }

    }
}
