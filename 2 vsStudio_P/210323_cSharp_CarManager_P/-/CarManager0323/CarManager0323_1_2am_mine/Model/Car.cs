using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Car
    {
        string model;
        int price;
        string color;
        string company;
        string year;

        public Car(string model, int price, string color, 
            string company, string year)
        {
            this.model = model;
            this.price = price;
            this.color = color;
            this.company = company;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public string Year { get => year; set => year = value; }
    }
}
