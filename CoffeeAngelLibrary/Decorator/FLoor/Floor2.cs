using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary.Decorator.FLoor
{
    public class Floor2 : AngelCoffee
    {
        public string name { get; set; }
        public Floor2() : base()
        {
            name = "AngelCoffee Floor2";
        }

        public double GetCalcuateCost()
        {
            return 2.00;
        }

        public string GetDescription()
        {
            return name;
        }
        public  string Infor()
        {
            return "Items detail: " ;
        }

    }
}
