using CoffeeAngelLibrary;
using CoffeeAngelLibrary.Decorator.ComponentDecor;
using CoffeeAngelLibrary.Decorator.FLoor;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoffeeAngelConsole
{
    public class Program
    {


        //public static Windown windown;
        //public static Tableset tableset;
        //public static PotTree pot;
        //public static Light light;
        //public static BookShelf bookself;
        //public static Floor1 floor1;
        //public static Floor2 floor2;
        //public static void Main(string[] args)
        //{
        //    int choose;


        //    do  
        //    {
        //   Console.WriteLine("Welcome to AngelCoffee Systems");
        //    Console.WriteLine("************************************");
        //    Console.WriteLine("your choice option is: ");
        //    Console.WriteLine("1. choice FLoor you Want Decorator: ");
        //    Console.WriteLine("2. Add Component Decoration ");
        //    Console.WriteLine("3. Display");
        //    Console.WriteLine("0. Exit");
        //    Console.WriteLine("**********pai pai***********");

        //        Console.WriteLine("enter your option: ");


        //        choose = int.Parse(Console.ReadLine());
        //        try
        //        {
        //            switch (choose)
        //            {
        //                case 1:
        //                    Console.WriteLine("you have choice Option1");
        //                    choiceFloor();
        //                    break;
        //                case 2:
        //                    Console.WriteLine("you have choice Option2");
        //                    addFloor1(floor1);
        //                    break;
        //                case 3:
        //                    Console.WriteLine("you have choice Option3: ");
        //                    display();
        //                    break;
        //                case 0:
        //                    break;
        //                default:
        //                    Console.WriteLine(" this Choose don't exist, Please choose again");
        //                    break;
        //            }

        //        }
        //        catch (System.Exception)
        //        {
        //            Console.WriteLine("--------------------");
        //            Console.WriteLine("Your choice is incorrect !");
        //            Console.WriteLine("--------------------");
        //        }

        //    } while (choose < 0 || choose > 6);

        //    //add compent floor 1 . limit componetn
        //}
        ////create ham choose, neu chon qua 5 truong hop hien thi thong bao loi
        ////use try catch de bat loi


        //    public static void choiceFloor()
        //{
        //    Console.WriteLine("Please choose the floor you want to decorate");
        //    Console.WriteLine("_______1. Floor1 _____________");
        //    Console.WriteLine("_______2. FLoor2 ____________");


        //    int choose = int.Parse(Console.ReadLine());
        //    if (choose < 0 || choose > 2)
        //    {
        //        Console.WriteLine("The Floor Don't exist");
        //    }
        //    else
        //    {
        //        switch (choose)
        //        {
        //            case 1:
        //                // Floor1 floor1 = new Floor1();
        //                Console.WriteLine("you have choose: ");
        //                floor = new Floor1();
        //                Console.WriteLine(floor.ToString());
        //                addFloor1(floor1);
        //                break;
        //            case 2:
        //                Console.WriteLine("you have choose: ");
        //                floor = new Floor2();
        //                Console.WriteLine(floor.ToString());
        //                break;
        //            default:
        //                Console.WriteLine("no choice");
        //                break;
        //        }

        //    }
        //    Console.Read();
        //}
        //public static void display()
        //{

        //    foreach(AngelCoffee floor1  in ListFloor1)
        //    {
        //        Console.WriteLine(floor1.ToString());
        //    }
        //    Console.WriteLine(ListFloor1.Count);
        //}
        ////check



        //public static List<AngelCoffee> ListItem = new List<AngelCoffee>();
        //public static List<AngelCoffee> ListFloor1 = new List<AngelCoffee>();
        //public static List<AngelCoffee> ListFloor2 = new List<AngelCoffee>();
        //public static void  addFloor1(AngelCoffee  floor1 )
        //{
        //    int Limit;
        //    int Add;
        //    int amount;

        //    do
        //    {

        //    Console.WriteLine("1.  add Windown?");
        //    Console.WriteLine("2.  add TableSet?");
        //    Console.WriteLine("3.  add Pottree?");
        //    Console.WriteLine("4.  add Light?");
        //    Console.WriteLine("5.  add bookShelf?");
        //    Console.WriteLine("6 . Pai Pai!!!");

        //      AngelCoffee floor = new Floor1();

        //        Console.WriteLine("enter Component you want to add: ");
        //        Add = int.Parse(Console.ReadLine());
        //        switch (Add)
        //        {

        //            case 1:
        //                    Console.Write("enter amount: ");
        //                    amount = Convert.ToInt32(Console.ReadLine());
        //                    Limit = 2;
        //                if (amount <= 0 || amount > Limit)
        //                 { Console.WriteLine("you can't add Windown, please reChoice"); }
        //                else
        //                {
        //                    for (int i = 1; i <= amount; i++)
        //                    {
        //                        floor = new Windown(floor);
        //                    }
        //                    Console.WriteLine(floor.ToString());
        //                    Console.WriteLine(floor.Total_cost());
        //                   // ListFloor1.Add(floor);
        //                }
        //                    break;

        //            case 2:

        //                    Console.WriteLine("enter amount: ");
        //                    amount = int.Parse(Console.ReadLine());
        //                    Limit = 3;
        //                    if (amount <= 0 || amount > Limit)
        //                    { Console.WriteLine("you can't add TableSet, please reChoice"); }
        //                    else
        //                    {
        //                        for (int i = 1; i <= amount; i++)
        //                        {
        //                        floor = new Tableset(floor);

        //                        }
        //                    Console.WriteLine(floor.ToString());
        //                    Console.WriteLine(floor.Total_cost());
        //                    ListFloor1.Add(floor);

        //                }
        //                    break;

        //            case 3:

        //                    Console.WriteLine("you Want add Pot to: ");
        //                    Console.WriteLine("enter amount: ");
        //                    amount = int.Parse(Console.ReadLine());
        //                    Limit = 2;
        //                    if (amount <= 0 || amount > Limit)
        //                    { Console.WriteLine("you can't add PotTree, please reChoice"); }
        //                    else
        //                    {
        //                        for (int i = 1; i <= amount; i++)
        //                        {
        //                        floor = new PotTree(floor);
        //                        Console.WriteLine(floor.ToString());

        //                         }
        //                    Console.WriteLine(floor.ToString());
        //                    Console.WriteLine(floor.Total_cost());
        //                    ListFloor1.Add(floor);
        //                }

        //                break;

        //            case 4:

        //                    Console.WriteLine("you Want add tableSet to: " );
        //                    Console.WriteLine("enter amount: ");
        //                    amount = int.Parse(Console.ReadLine());
        //                    Limit = 3;
        //                    if (amount <= 0 || amount > Limit)
        //                    { Console.WriteLine("you can't add light, please reChoice"); }
        //                    else
        //                    {
        //                        for (int i = 1; i <= amount; i++)
        //                        {
        //                        floor = new Light(floor);

        //                        }
        //                    Console.WriteLine(floor.ToString());
        //                    Console.WriteLine(floor.Total_cost());
        //                    ListFloor1.Add(floor);
        //                }

        //                break;
        //            case 5:

        //                    Console.WriteLine("you Want add tableSet to: " + floor);
        //                    Console.WriteLine("enter amount: ");
        //                    amount = int.Parse(Console.ReadLine());
        //                    Limit = 3;
        //                    if (amount <= 0 || amount > Limit)
        //                    { Console.WriteLine("you can't add bookself, please reChoice"); }
        //                    else
        //                    {
        //                        for (int i = 1; i <= amount; i++)
        //                        {
        //                        floor = new BookShelf(floor);
        //                        }
        //                    Console.WriteLine(floor.ToString());
        //                    Console.WriteLine(floor.Total_cost());
        //                    ListFloor1.Add(floor);

        //                }

        //                break;
        //            case 6:
        //                break;
        //            default:
        //                Console.WriteLine(" Please choose again!");
        //                break;
        //        }

        //    } while (Add != 6);





        //}


        //public static void choiceFloor()
        //{
        //    Console.WriteLine("Please choose the floor you want to decorate");
        //    Console.WriteLine("_______1. Floor1 _____________");
        //    Console.WriteLine("_______2. FLoor2 ____________");
        //    //Console.WriteLine("_______0. Exit   ____________");


        //    int choose = int.Parse(Console.ReadLine());
        //    if (choose < 0 || choose > 2)
        //    {
        //        Console.WriteLine("The Floor Don't exist");
        //    }
        //    else
        //    {1
        //        switch (choose)
        //        {
        //            case 1:
        //                // Floor1 floor1 = new Floor1();
        //                Console.WriteLine("you have choose floor1");
        //                floor = new Floor1();

        //                break;
        //            case 2:
        //                Console.WriteLine("you have choose floor2 ");
        //                floor = new Floor2();
        //                break;

        //            default:
        //                Console.WriteLine("Exit");
        //                break;
        //        }

        //    }
        //    Console.ReadLine();
        //}



        public static void Add(AngelCoffee angelCoffee, FloorLimits floorlimits)
        {
            int choice = 0;


            do
            {

                Console.WriteLine("--------------------------");
                Console.WriteLine("| 1.  add Windown?        |");
                Console.WriteLine("| 2.  add TableSet?       |");
                Console.WriteLine("| 3.  add Pottree?        |");
                Console.WriteLine("| 4.  add Light?          |");
                Console.WriteLine("| 5.  add bookShelf?      |");
                Console.WriteLine("| 6 . Exit!!!             |");
                Console.WriteLine("--------------------------");

                Console.Write("Enter your choose: ");
                do
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (choice < 0 || choice > 6)
                        {
                            Console.WriteLine("Enter a valid number");
                        }
                    }
                    catch (System.Exception)
                    {
                        choice = -1;
                        Console.WriteLine("Invalid number");
                    }


                } while (choice < 0 || choice > 6);

                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You've added windown to floor");
                        Console.Write("enter amount:  ");
                        int wd = int.Parse(Console.ReadLine());

                        if (floorlimits.CheckLimit(angelCoffee.GetDescription(),  "windown"))
                        {
                            for (int i = 0; i <= wd; i++)
                            {
                                angelCoffee = new Windown(angelCoffee);

                            }
                            Console.WriteLine(angelCoffee.Infor());

                        }
                        break;
                    //case 2:
                    //    Console.WriteLine("You've added tableset to floor");
                    //    Console.Write("enter amount:  ");
                    //    int tb = int.Parse(Console.ReadLine());
                    //    if (floorlimits.CheckLimit(angelCoffee, "tableset"))
                    //    {
                    //        for (int i = 1; i <= tb; i++)
                    //        {
                    //            angelCoffee = new Tableset(angelCoffee);

                    //        }

                    //    }
                    //    Console.WriteLine(angelCoffee.Infor());
                    //    break;
                    //case 3:
                    //    Console.WriteLine("You've added pottree to floor");

                    //    Console.Write("enter amount:  ");
                    //    int pt = int.Parse(Console.ReadLine());
                    //    if (floorlimits.CheckLimit(angelCoffee, "pottree"))
                    //    {
                    //        for (int i = 1; i <= pt; i++)
                    //        {
                    //            angelCoffee = new PotTree(angelCoffee);

                    //        }
                    //        Console.WriteLine(angelCoffee.Infor());
                    //    }

                    //    break;
                    //case 4:
                    //    Console.WriteLine("You've added light to floor");
                    //    Console.Write("enter amount:  ");
                    //    int lt = int.Parse(Console.ReadLine());
                    //    if (floorlimits.CheckLimit(angelCoffee, "light"))
                    //    {
                    //        for (int i = 1; i <= lt; i++)
                    //        {
                    //            angelCoffee = new Light(angelCoffee);

                    //        }
                    //        Console.WriteLine(angelCoffee.Infor());
                    //    }
                    //    break;
                    //case 5:
                    //    Console.WriteLine("You've added bookself to floor");
                    //    Console.Write("enter amount:  ");
                    //    int bk = int.Parse(Console.ReadLine());
                    //    if (floorlimits.CheckLimit(angelCoffee, "bookself"))
                    //    {
                    //        for (int i = 1; i <= bk; i++)
                    //        {
                    //            angelCoffee = new BookShelf(angelCoffee);

                    //        }
                    //        Console.WriteLine(angelCoffee.Infor());
                    //    }

                    //    break;
                    case 6:
                        Console.WriteLine("return main");
                        break;
                    default:
                        break;
                }

            } while (choice != 6);
            lcompo.Add(angelCoffee);
            Console.WriteLine("{0},Total Price: {1}", angelCoffee.GetDescription(), angelCoffee.GetCalcuateCost());
        }


        public static void Displaydetail(List<AngelCoffee> angelCoffee)
        {


            double total = 0;
            for (int i = 0; i < angelCoffee.Count; i++)
            {

                total += angelCoffee[i].GetCalcuateCost();

            }
            Console.WriteLine(" --------------------------- ");
            Console.WriteLine("Total price: " + total);

        }
        public static List<AngelCoffee> lcompo = new List<AngelCoffee>();

        static void Main(string[] args)
        {
            FloorLimits floorlimits = new FloorLimits();


            int choice;

            do
            {
                Console.WriteLine("--------choose floor-------");
                Console.WriteLine("--------1. Floor1   -------");
                Console.WriteLine("--------2. Floor2   -------");
                Console.WriteLine("--------3. List     -------");
                Console.WriteLine("--------4. Exit     -------");
                do
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (choice < 0 || choice > 4)
                        {
                            Console.WriteLine("Enter a valid number");
                        }
                    }
                    catch (System.Exception)
                    {
                        choice = -1;
                        Console.WriteLine("Invalid number");
                        Console.WriteLine("Enter a valid number");
                    }


                } while (choice < 0 || choice > 6);


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You choose floor1");
                        Floor1 floor1 = new Floor1();
                        //add vào listfloor

                        Add(floor1, floorlimits);
                        break;
                    case 2:
                        Console.WriteLine("You choose floor2");
                        Floor2 floor2 = new Floor2();
                        Add(floor2, floorlimits);
                        break;
                    case 3:
                        Console.WriteLine("you choose display detail");
                        Displaydetail(lcompo);
                        break;
                    case 4:
                        Console.WriteLine("You choose exit");
                        return;
                    default:
                        Console.WriteLine("Choose again");
                        break;
                }

            } while (choice != 4);

        }





        //        public static void Main(string[] args)
        //        {
        //            AngelCoffee floor1 = new Floor1();
        //            AngelCoffee floor2 = new Floor2();


        //            int limit = 0;
        //            int count = 1;
        //            bool checkLimit = false;
        //            while (true)
        //            {
        //                try
        //                {
        //                    Console.WriteLine("--------------------------");
        //                    Console.WriteLine("| 1.  add Windown?        |");
        //                    Console.WriteLine("| 2.  add TableSet?       |");
        //                    Console.WriteLine("| 3.  add Pottree?        |");
        //                    Console.WriteLine("| 4.  add Light?          |");
        //                    Console.WriteLine("| 5.  add bookShelf?      |");
        //                    Console.WriteLine("| 0 . Exit!!!             |");
        //                    Console.WriteLine("--------------------------");

        //                    Console.Write("Enter your choose: ");

        //                    int add = Convert.ToInt32(Console.ReadLine());
        //                    int amount = Convert.ToInt32(Console.ReadLine());


        //                    //Console.WriteLine( floor1);

        //                    //display();

        //                    switch (add)
        //                    {
        //                        case 1:
        //                            Console.WriteLine("----------------------");
        //                            Console.WriteLine("You choose add windown");
        //                            display();
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("| 1. Choose floor1  |");
        //                            Console.WriteLine("| 2. Choose floor2  |");
        //                            Console.WriteLine("| 0. Exit           |");
        //                            Console.WriteLine("---------------------");
        //                            Console.Write("Enter your choose: ");

        //                            int windown = Convert.ToInt32(Console.ReadLine());
        //                            //int amount = Convert.ToInt32(Console.ReadLine());
        //                            Console.Write("enter amount: ");

        //                            switch (windown) 
        //                            {
        //                                case 1: 
        //                                    //limit = 3;
        //                                    if (amount <= 0 || amount > 3)
        //                                    { Console.WriteLine("you can't add Windown, please reChoice"); }
        //                                    else
        //                                    {
        //                                        for (int i = 1; i <= amount; i++)
        //                                        {
        //                                            if (count <= 3)
        //                                            {
        //                                                floor1 = new Windown(floor1);
        //                                                //floor1.ToString();
        //                                                count++;
        //                                            }
        //                                            else
        //                                            {
        //                                                //checkLimit = true;
        //                                                Console.WriteLine("you have insert the limit amount");
        //                                                break;
        //                                            }
        //                                        }

        //                                        BookShelf floor = new BookShelf(floor1);
        //                                        Console.WriteLine(floor1.Infor());
        //                                        Console.WriteLine(floor1.GetDescription());
        //                                        Console.WriteLine(floor1.GetCalcuateCost());
        //                                    }

        //                                    break;

        //                                case 2:
        //                                    //limit floor2 = 5 
        //                                    //limit = 5; 
        //                                    if(amount <= 0 || amount > 6)
        //                                    {
        //                                        { Console.WriteLine("you can't add Windown, please reChoice"); }
        //                                    }
        //                                    else
        //                                    {
        //                                        for(int i = 1; i <= amount; i++)
        //                                        {
        //                                            if(count <= 6)
        //                                            {
        //                                                floor2 = new Windown(floor2);
        //                                                count++; 
        //                                            }
        //                                            else
        //                                            {

        //                                                Console.WriteLine("you have insert the limit amount");
        //                                                break;
        //                                            }
        //                                        }
        //                                    }
        //                                    Console.WriteLine(floor2.Infor());
        //                                    Console.WriteLine(floor2.GetDescription());

        //                                    Console.WriteLine(floor2.GetCalcuateCost());

        //                                    break;
        //                            }

        //                            break;



        //                        case 2:
        //                            Console.WriteLine("----------------------");
        //                            Console.WriteLine("You choose add Tableset");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("| 1. Choose floor1  |");
        //                            Console.WriteLine("| 2. Choose floor2  |");
        //                            Console.WriteLine("| 0. Exit           |");
        //                            Console.WriteLine("---------------------");
        //                            Console.Write("Enter your choose: ");

        //                            int tableset = Convert.ToInt32(Console.ReadLine());
        //                            Console.Write("enter amount: ");
        //                            switch (tableset)
        //                            {
        //                                case 1:
        //                                    if (amount <= 0 || amount > 3)
        //                                    { Console.WriteLine("you can't add Windown, please reChoice"); }
        //                                    else
        //                                    {
        //                                        for (int i = 1; i <= amount; i++)
        //                                        {
        //                                            if (count <= 3)
        //                                            {
        //                                                floor1 = new Tableset(floor1);
        //                                                //floor1.ToString();
        //                                                count++;
        //                                            }
        //                                            else
        //                                            {
        //                                                //checkLimit = true;
        //                                                Console.WriteLine("you have insert the limit amount");
        //                                                break;
        //                                            }
        //                                        }
        //                                        Tableset floor = new Tableset(floor1);
        //                                        Console.WriteLine(floor1.Infor());
        //                                        Console.WriteLine(floor1.GetDescription());

        //                                        Console.WriteLine(floor1.GetCalcuateCost());
        //                                    }
        //                                    break;

        //                                case 2:

        //                                    if (amount <= 0 || amount > 3)
        //                                    { Console.WriteLine("you can't add Windown, please reChoice"); }
        //                                    else
        //                                    {
        //                                        for (int i = 1; i <= amount; i++)
        //                                        {
        //                                            if (count <= 3)
        //                                            {
        //                                                floor1 = new Tableset(floor1);
        //                                                //floor1.ToString();
        //                                                count++;
        //                                            }
        //                                            else
        //                                            {
        //                                                //checkLimit = true;
        //                                                Console.WriteLine("you have insert the limit amount");
        //                                                break;
        //                                            }
        //                                        }
        //                                        Tableset floor = new Tableset(floor2);
        //                                        Console.WriteLine(floor2.Infor());
        //                                        Console.WriteLine(floor2.GetDescription());
        //                                        Console.WriteLine(floor2.GetCalcuateCost());

        //                                    }
        //                                        break;

        //                                case 0:
        //                                    Console.WriteLine();
        //                                    break;

        //                            }
        //                            Console.WriteLine("--------------------");
        //                            break;
        //                        case 3:
        //                            Console.WriteLine("----------------------");
        //                            Console.WriteLine("You choose add PotTree");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("| 1. Choose floor1  |");
        //                            Console.WriteLine("| 2. Choose floor2  |");
        //                            Console.WriteLine("| 0. Exit           |");
        //                            Console.WriteLine("---------------------");
        //                            Console.Write("Enter your choose: ");

        //                            int pottree = Convert.ToInt32(Console.ReadLine());

        //                            switch (pottree)
        //                            {
        //                                case 1:
        //                                    floor1 = new PotTree(floor1);
        //                                    Console.WriteLine(floor1.GetDescription());
        //                                    Console.WriteLine(floor1.GetCalcuateCost());
        //                                    break;
        //                                case 2:
        //                                    floor2 = new PotTree(floor2);
        //                                    Console.WriteLine(floor2.GetDescription());
        //                                    Console.WriteLine(floor2.GetCalcuateCost());
        //                                    break;

        //                            }
        //                            break;

        //                        case 4:
        //                            Console.WriteLine("----------------------");
        //                            Console.WriteLine("You choose add Light");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("| 1. Choose floor1  |");
        //                            Console.WriteLine("| 2. Choose floor2  |");
        //                            Console.WriteLine("| 0. Exit           |");
        //                            Console.WriteLine("---------------------");
        //                            Console.Write("Enter your choose: ");

        //                            int light = Convert.ToInt32(Console.ReadLine());

        //                            switch (light)
        //                            {
        //                                case 1:
        //                                    floor1 = new Light(floor1);
        //                                    Console.WriteLine(floor1.GetDescription());
        //                                    Console.WriteLine(floor1.GetCalcuateCost());
        //                                    break;
        //                                case 2:
        //                                    floor2 = new Light(floor2);
        //                                    Console.WriteLine(floor2.GetDescription());
        //                                    Console.WriteLine(floor2.GetCalcuateCost());
        //                                    break;
        //                                case 0:
        //                                    Console.WriteLine();
        //                                    break;

        //                            }
        //                            Console.WriteLine("--------------------");
        //                            break;

        //                        case 5:

        //                            Console.WriteLine("----------------------");
        //                            Console.WriteLine("You choose add BookShelf");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("---------------------");
        //                            Console.WriteLine("| 1. Choose floor1  |");
        //                            Console.WriteLine("| 2. Choose floor2  |");
        //                            Console.WriteLine("| 0. Exit           |");
        //                            Console.WriteLine("---------------------");
        //                            Console.Write("Enter your choose: ");

        //                            int bookshelf = Convert.ToInt32(Console.ReadLine());
        //                            BookShelf infor = new BookShelf(floor1);

        //                            Console.WriteLine(floor1);
        //                            switch (bookshelf)
        //                            {

        //                                case 1:

        //                                    floor1 = new BookShelf(floor1);

        //                                    Console.WriteLine(floor1.GetDescription());
        //                                    Console.WriteLine(floor1.GetCalcuateCost());
        //                                    Console.WriteLine(infor.ToString());
        //                                    //Console.WriteLine(floor1.Infor());
        //                                    break;
        //                                case 2:
        //                                    floor2 = new BookShelf(floor2);

        //                                    Console.WriteLine(floor2.GetDescription());
        //                                    Console.WriteLine(floor2.GetCalcuateCost());
        //                                    //Console.WriteLine(floor2.Infor());

        //                                    break;
        //                                case 0:
        //                                    Console.WriteLine();
        //                                    break;

        //                            }
        //                            Console.WriteLine("--------------------");
        //                            break;

        //                        case 0:
        //                            Console.WriteLine("--------------------");
        //                            Console.WriteLine("\n Exit program ");
        //                            Console.WriteLine("--------------------");
        //                            return;
        //                    }

        //                }
        //                catch 
        //                {
        //                    Console.WriteLine("--------------------------");
        //                    Console.WriteLine("Invalid input, please choice again!");
        //                    Console.WriteLine("--------------------------");
        //                }
        //            }
        //        }
    }
}



