using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask.Models
{
    internal class Car
    {
        //TODO on the site Engines are not the same on two different pages.
        //There are no doors also
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string DoorCount { get; set; }
        public string Seats { get; set; }
        public string Engine { get; set; }

        public Car(string maker, string model, string year)
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
