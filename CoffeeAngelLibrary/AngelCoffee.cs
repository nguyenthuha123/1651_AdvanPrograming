using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary
{ public interface AngelCoffee
    {

        //constructor default

        // main action
        //  public abstract double Total_cost();

        // public abstract string ToString();

        string GetDescription();
        double GetCalcuateCost();
        //string ToString();
        string Infor();

    }
}
