using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask
{
    internal class Car
    {
        private string Maker { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private string DoorCount { get; set; }
        private string Seats { get; set; }
        private string Engine { get; set; }

        public Car(string maker, string model, int year)
        {
            Maker = maker;
            Model = model;
            Year = year;
            DoorCount = "zero";
            Seats = "zero";
            Engine = "zero";
        }

        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   Maker == car.Maker &&
                   Model == car.Model &&
                   Year == car.Year &&
                   DoorCount == car.DoorCount &&
                   Seats == car.Seats &&
                   Engine == car.Engine;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Maker, Model, Year, DoorCount, Seats, Engine);
        }
    }
}
