using System;

namespace ExampleProject.mytask.Models
{
    internal class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string? Price { get; set; }
        public string? Trim { get; set; }

        public Car(string maker, string model, string year)
        {
            Maker = maker;
            Model = model;
            Year = year;
        }
    }
}
