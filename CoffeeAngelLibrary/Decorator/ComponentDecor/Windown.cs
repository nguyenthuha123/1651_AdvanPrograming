using CoffeeAngelLibrary.Decorator.ComponentDecor;
using CoffeeAngelLibrary.Decorator.FLoor;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CoffeeAngelLibrary.Decorator.ComponentDecor
{
    public class Windown : FloorDecorator
    {

        public string category { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int size { get; set; }
        private double _price;
        public double price
        {
            get { return _price; }
            private set { _price = value; }
        }
       
        public Windown(AngelCoffee floordecorator) : base(floordecorator)
        {
            this.category = "Temperred glass";
            this.name = "Windown";
            this.color = "White";
            this.size = 32;
            this.price = 350.00;
        }


        public override string GetDescription()
        {
            return base.GetDescription() + " " + "_" + this.name;
        }

        public override double GetCalcuateCost()
        {
            return base.GetCalcuateCost() + 300.00;
        }

        public override string Infor()
        {
            return "Items detail: " + " {"
            + "Category: " + this.category + ","
            + "Color: " + this.color + ","
            + "Size: " + this.size + ","
            + "Price: " + this.price + "}";
        }

    
    }

}

                              

