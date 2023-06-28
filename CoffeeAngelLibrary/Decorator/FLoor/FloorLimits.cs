using CoffeeAngelLibrary;
using CoffeeAngelLibrary.Decorator.FLoor;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class FloorLimits
{
    private Dictionary<string, Dictionary<string, int>> itemCounts;
    
    //constuctor
    public FloorLimits()
    {
        itemCounts = new Dictionary<string, Dictionary<string, int>>();
       
    }


    public bool CheckLimit(string floor, string item)
    {
        //string floor = angelCoffee.GetDescription();
        //kiem tra xem floor có tồn tại trong itemcount
        if (!itemCounts.ContainsKey(floor))
        {
            itemCounts[floor] = new Dictionary<string, int>();

        }
        //dicti

        //lay limit items
        int limit = GetLimitForItem(floor, item);
       
        //kiem tra xem items ton tai trong dicton[floor] ?
        if (itemCounts[floor].ContainsKey(item))
        {
            if (itemCounts[floor][item] < limit)
            {

                itemCounts[floor][item]++;
                return true;
            }
            else
            {
                Console.WriteLine($"You have inserted the limit for {item} in {floor}");
                return false;
            }
        }
        else
        {
            //neu item khong ton tai trong dictonary itemscount[floor] 
            itemCounts[floor][item] = 1;
            return true;
        }
        
    }

    private int GetLimitForItem(string floor, string item)
    {
        if (string.Equals(floor, "Floor1", StringComparison.OrdinalIgnoreCase))
        {
            switch (item)
            {
                case "bookshelf":
                    return 3 ;
                case "light":
                    return 5;
                case "pottree":
                    return 3;
                case "tableset":
                    return 6;
                case "windown":
                    return 3;
                default:
                    return 0;
            }
        }

        else if (string.Equals(floor, "Floor2", StringComparison.OrdinalIgnoreCase))
        {
            switch (item)
            {
                case "bookshelf":
                    return 5;
                case "light":
                    return 3;
                case "pottree":
                    return 3;
                case "tableset":
                    return 5;
                case "windown":
                    return 3;
                default:
                    return 0;
            }
        }

        else
        {
            return 0;
        }

    }
}


