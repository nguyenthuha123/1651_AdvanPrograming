using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary.Decorator.ComponentDecor
{
    public class Light : FloorDecorator
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

    
        public Light(AngelCoffee floordecorator) : base(floordecorator)
        {

            this.category = "glass";
            this.name = "Light";
            this.color = "yellow";
            this.price = 110.00;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "added" + " " + "_" + this.name;
        }

        public override string Infor()
        {
            return  "Items detail: {"
            + "Category: " + this.category + ","
            + "Color: " + this.color + ","
           
            + "Price: " + this.price + "}";
        }

        public override double GetCalcuateCost()
        {
            return base.GetCalcuateCost() + 250.00;
        }

    }
}
