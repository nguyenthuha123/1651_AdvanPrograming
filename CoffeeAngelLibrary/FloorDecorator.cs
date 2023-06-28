using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary
{
   

    public abstract class FloorDecorator : AngelCoffee
    {
        protected AngelCoffee _angelCoffee; 
        public string GetDescriptions { get; set; }
        public string CalcuateCost { get; set; }
        //public string ToString { get; set; }
        //public string Infor { get; set; }

        //parameter 
        //constructor nhan oject cua base(angelcoffe) 
        //cong them compence voi lop base
        public  FloorDecorator(AngelCoffee angelCoffee)
        {
            _angelCoffee = angelCoffee;
        }
        public virtual string GetDescription()
        {
            return _angelCoffee.GetDescription();
        }
        public virtual double GetCalcuateCost()
        {
            return _angelCoffee.GetCalcuateCost();
        }


        public virtual string Infor()
        {
            return _angelCoffee.Infor();
        }
      
    }
}
