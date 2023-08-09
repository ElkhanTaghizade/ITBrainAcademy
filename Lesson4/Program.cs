using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList shoppinglist = new ArrayList();
            shoppinglist.Add("Fish");
            shoppinglist.Add("Friut");
            shoppinglist.Add("Eggs");
            shoppinglist.Add("Honey");
            shoppinglist.Add("Bread");
            shoppinglist.Add("Rice");
            shoppinglist.Add("Bread");


            Console.WriteLine("Add item: 1");
            Console.WriteLine("Display list: 2");
            Console.WriteLine("Check item: 3");
            Console.WriteLine("Exit: 4");
            int select=Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:

                    Console.WriteLine("Write the number of the item you want to add:");
                    int num = Convert.ToInt32(Console.ReadLine());


                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Write the items you want to add:");
                        string object1 = Console.ReadLine();
                        shoppinglist.Add(object1);
                    }
                    Console.WriteLine("Items added.");
                    Console.ReadLine();
                    break;

                case 2:

                    foreach (var item in shoppinglist)
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadLine();
                    break;

                case 3:

                    Console.WriteLine("Enter the name of the product you want to learn about:");
                    string checkproduct = Console.ReadLine();
                    string a;
                    int count=0;

                    foreach (string item in shoppinglist )

                    {
                        a = item;
                        

                        if (checkproduct == item)
                        {
                            
                            count++;
                            Console.WriteLine($"There are {count} {item} on the list");

                        }
                      
                    }
                    bool True = count == 0;
                    if (True)
                    {

                        Console.WriteLine("This item is not on the list.");

                    }


                    break;
                 
                case 4:
                    Console.WriteLine("Exit...");

                    break;

                default:
                    Console.WriteLine("Wrong button.");
                    break;
            }
        }
    }
}
