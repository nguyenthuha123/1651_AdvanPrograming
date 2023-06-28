using CoffeeAngelLibrary.Decorator.FLoor;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary.Decorator.ComponentDecor
{
    public class BookShelf : FloorDecorator
    {
        

        public string category { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int size { get; set; }
        private double _price;
        public double price {
            get { return _price; } 
            private set { _price = value; } 
        }

        public BookShelf(AngelCoffee floordecorator) : base(floordecorator)
        {
            this.category = "wood";
            this.name = "Bookself";
            this.color = "White";
            this.size = 45;
            this.price = 400.00;
        }

        public override string GetDescription()
        {
            return base.GetDescription()  + this.name;
        }

        public override string Infor()
        {
            return  "Items detail: {"
            + "Category: " + this.category + ","
            + "Color: " + this.color + ","
            + "Size: " + this.size + ","
            + "Price: " + this.price + "}";
        }

   


        public override double GetCalcuateCost()
        {
            return base.GetCalcuateCost() + 250.00;
        }

    }
}
