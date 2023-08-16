using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                   Shopping List");
            ArrayList shoppinglist = new ArrayList();
            var shoppinglistin1 = new
            {
                Item="Bread",
                Amount=2,
            };
            var shoppinglistin2 = new
            {
                Item = "Egg",
                Amount = 20,
            };
            shoppinglist.Add(shoppinglistin1);
            shoppinglist.Add(shoppinglistin2);

            bool check = true;
            while (check)    
            {
                Console.WriteLine("");
                Console.WriteLine("Choose from the following.");
                Console.WriteLine("Add shopping item: 1");
                Console.WriteLine("Display items by category: 2");
                Console.WriteLine("Exit: 3");
                string choose=Console.ReadLine();
              
                switch (choose)
                    {
                        case "1":

                            Console.WriteLine("Enter the number of the item you want to add:");
                            byte itemnum = Convert.ToByte(Console.ReadLine());

                            for (int i = 0; i < itemnum; i++)
                            {

                                Console.WriteLine("Enter the item you want to add");
                                string item = Console.ReadLine();
                                Console.WriteLine("Enter the amount of the item you want to add");
                                int itemamount = Convert.ToInt32(Console.ReadLine());

                                var shoppingadd = new
                                {
                                    Item = item,
                                    Amount = itemamount
                                };
                                shoppinglist.Add(shoppingadd);

                            }
                            Console.WriteLine("Items added.");
                            Console.WriteLine("");
                            foreach (var items2 in shoppinglist)
                            {
                                Console.WriteLine(items2);
                            }

                            break;

                        case "2":

                            foreach (object items in shoppinglist)
                            {
                                Console.WriteLine(items);
                            }

                            break;

                        case "3":

                            check = false;
                            Console.WriteLine("Exit...");

                            break;

                        default:

                            Console.WriteLine("Wrong button.");

                            break;
                    }
                
            }

        }
    }
}
