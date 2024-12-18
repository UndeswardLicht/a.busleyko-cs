using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask.Models
{
    internal class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Engine { get; set; } = string.Empty;


        //todo change add необязательные поля
        public Car(string maker, string model, string year)
        {
            Maker = maker;
            Model = model;
            Year = year;
        }

        //todo delete the equals as it works fine from the box
        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   Maker == car.Maker &&
                   Model == car.Model &&
                   Year == car.Year &&
                   Engine == car.Engine;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Maker, Model, Year, Engine);
        }
    }
}
