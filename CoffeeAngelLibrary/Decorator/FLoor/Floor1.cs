using CoffeeAngelLibrary.Decorator.ComponentDecor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAngelLibrary.Decorator.FLoor
{
    public class Floor1 : AngelCoffee
    {
        //public string name { get; set; }

        ////default
        //public Floor1() : base()
        //{
        //    name = "floor1";

        //}
        ////action
        ////check limit. 

        //public override string ToString()
        //{
        //    return "AngelCoffe With" + name;
        //}
        //public override double Total_cost()
        //{
        //    return 1.00;
        //}

        //constructor floor
        //private int bookshelfCount;
        //private int lightCount;
        //private int pottreeCount;
        //private int tablesCount;
        //private int windownCount;
       
        public string name { get; set; }
        public Floor1() : base()
        {
            name = "AngelCoffee Floor1";
        }
        public double GetCalcuateCost()
        {
            return 1.00;
        }

        public string GetDescription()
        {
            return name;
        }
        public  string Infor()
        {
            return "Items detail: ";
        }

        //public bool CheckLimit(string item)
        //{
        //    if (item == "bookshelf")
        //    {
        //        if (bookshelfCount < 3)  // Giới hạn cho bookshelf trên floor1
        //        {
        //            bookshelfCount++;
        //            return true;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You have reached the limit for bookshelf on floor1");
        //            return false;
        //        }
        //    }
        //    else if (item == "light")
        //    {
        //        Console.WriteLine("You have reached the limit for bookshelf on floor1");
        //        return false;
        //    }
        //    else if (item == "pottree")
        //    {
        //        Console.WriteLine("You have reached the limit for bookshelf on floor1");
        //        return false;
        //    }
        //    else if (item == "tables")
        //    {
        //        Console.WriteLine("You have reached the limit for bookshelf on floor1");
        //        return false;
        //    }
        //    else if (item == "windown")
        //    {
        //        Console.WriteLine("You have reached the limit for bookshelf on floor1");
        //        return false;
        //    }
        //    return true;
        //}
    
    }
}
