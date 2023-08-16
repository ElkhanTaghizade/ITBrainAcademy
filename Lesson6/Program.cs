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
            Console.WriteLine("                                                       Shopping List");
            ArrayList categories = new ArrayList();
            var shoppinglistin1 = new
            {
                Category="Category1",
                Item="Bread",
                Amount=2,
            };
            var shoppinglistin2 = new
            {
                Category="Category1",
                Item = "Egg",
                Amount = 20,
            };
            var shoppinglist11 = new
            {
                Category = "Category2",
                Item = "Apple",
                Amount = 8
            };
            var shoppinglist22 = new
            {
                Category = "Category2",
                Item = "Orange",
                Amount = 6
            };
            categories.Add(shoppinglistin1);
            categories.Add(shoppinglistin2);
            categories.Add(shoppinglist11);
            categories.Add(shoppinglist22);


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
                            byte itemnumadd = Convert.ToByte(Console.ReadLine());

                        for (int i = 0; i < itemnumadd; i++)
                        {
                            Console.WriteLine("Enter the category you want to add:");
                            string categoryadd=Console.ReadLine();
                            Console.WriteLine("Enter the item you want to add:");
                            string itemadd = Console.ReadLine();
                            Console.WriteLine("Enter the amount of the item you want to add");
                            int itemamountadd = Convert.ToInt32(Console.ReadLine());

                            var add = new
                            {
                                category= categoryadd,
                                Item = itemadd,
                                Amount = itemamountadd
                            };
                            categories.Add(add);

                        }
                        Console.WriteLine("Items added.");
                     
                        break;

                        case "2":
                        foreach(dynamic item in categories)
                        {
                            Console.WriteLine(item.Category);
                        }
                          Console.WriteLine("Enter the category you want to display:");
                          string checkcategory=Console.ReadLine();

                        foreach(dynamic item in categories)
                        {
                            if(item.Category == checkcategory)
                            {
                                Console.WriteLine(item.Item);
                            }
                            else
                            {
                                Console.WriteLine("Category not found");
                            }

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
