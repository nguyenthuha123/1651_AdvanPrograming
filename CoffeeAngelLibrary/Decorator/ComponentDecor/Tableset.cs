using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary.Decorator.ComponentDecor
{
    public class Tableset : FloorDecorator
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


        public Tableset(AngelCoffee floordecorator) : base(floordecorator)
        {

            this.category = "wood";
            this.name = "Tableset";
            this.color = "brown";
            this.size = 45;
            this.price = 300.00;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "added" + " " + "_" + this.name;
        }
        public override string Infor()
        {
            return "Items detail: " + " {"
            + "Category: " + this.category + ","
            + "Color: " + this.color + ","
            + "Size: " + this.size + ","
            + "Price: " + this.price + "}";
        }

        public override double GetCalcuateCost()
        {
            return base.GetCalcuateCost() + 400.00;
        }

    }
}
