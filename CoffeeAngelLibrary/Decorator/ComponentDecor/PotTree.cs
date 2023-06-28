using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary.Decorator.ComponentDecor
{
    public class PotTree : FloorDecorator
    {
        public string category { get; set; }
        public string name { get; set; }
        public string color { get; set; }
       
        private double _price;
        public double price
        {
            get { return _price; }
            private set { _price = value; }
        }


        public PotTree(AngelCoffee floordecorator) : base(floordecorator)
        {
            this.category = "glass";
            this.name = "Pottree";
            this.color = "white";
            this.price = 500.00;
        }

        public override string GetDescription()
        {
            return base.GetDescription() +  " " + "_" + this.name;
        }

        public override string Infor()
        {
            return "Items detail: " + " {"
            + "Category: " + this.category + ","
            + "Color: " + this.color + ","
            + "Price: " + this.price + "}";
        }

        public override double GetCalcuateCost()
        {
            return base.GetCalcuateCost() + 50.00;
        }
    }
}
