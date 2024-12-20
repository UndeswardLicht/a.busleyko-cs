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
        public string Price { get; set; } = string.Empty;

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
                   Price == car.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Maker, Model, Year, Price);
        }
    }
}
