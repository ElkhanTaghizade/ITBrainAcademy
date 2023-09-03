using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pharmaceutical_System
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("                                                     Pharmaceutical_System ");
            bool check = true;
            while(check)
            {
                Console.WriteLine("");
                Console.WriteLine("To add medicine: 1");
                Console.WriteLine("To view medications: 2");
                Console.WriteLine("To sell medicine: 3");
                Console.WriteLine("To find medicine: 4");
                Console.WriteLine("To wiew total come in: 5");
                Console.WriteLine("Exit: 6");
                string choose=Console.ReadLine();
                switch(choose) 
                {
                    case "1":
                        Console.WriteLine("Enter medicine name:");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter medicine price:");
                        decimal price =Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter medicine count:");
                        int count =Convert.ToInt32(Console.ReadLine());
                        Pharmacy.AddMedicine(name, price, count);
                        break;
                    case "2":
                        Pharmacy.MedicinesDisplay();
                        break;
                    case "3":
                        Console.WriteLine("Enter the medicine name you want to sell:");
                        string namesell=Console.ReadLine();
                        Console.WriteLine("Enter count you want to sell:");
                        int countsell=Convert.ToInt32(Console.ReadLine());
                        Pharmacy.Sell(namesell, countsell);
                        break;
                    case "4":
                        Console.WriteLine("Enter name of medicine:");
                        string check1=Console.ReadLine();    
                        Pharmacy.FindMedicineByName(check1);
                            break;
                    case "5":
                        Pharmacy.TotalInComes();
                            break;
                    case "6":
                        check= false;
                        Console.WriteLine("Exit...");
                        break;
                    default: 
                        Console.WriteLine("Wrong button.");
                        break;
                }
            }
        }
    }
    public class Medicine
    {
        public static string Name { get; set; }
        public static decimal Price { get; set; }
        public static int Count { get; set; }
        public Medicine(string name, decimal price)
        {
            Name= name;
            Price = price;
        }
    }
    public static class Validation
    {
        public static bool Test(string name)
        {
            try
            {
                return !string.IsNullOrEmpty(name);
            }
            catch (Exception)
            {
                Console.WriteLine("Null or empty acces.");
                throw;
            }
        }
        public static bool Test(decimal price)
        {
            if (price <= 0)
            {
                return false;
            }
            return true;
        }
        public static bool Test(int count)
        {
            if (count < 0)
            {
                return false;
            }
            return true;
        }
    }
    public static class Pharmacy
    {
        public static List<object> medicines = new List<object>();
        public static List<string> name = new List<string>();
        public static List<decimal> price = new List<decimal>();
        public static List<int> count = new List<int>();
        public static decimal TotalInCome { get; set; }
        public static decimal Amount { get; set; }
        public static bool Contains(string name)
        {
            bool Contains = false;
            foreach(var item in Pharmacy.name)
            {
                if(name!=item || Pharmacy.name.Count==0)
                {
                    Contains = true;
                }
            }
            return Contains;
        }
        public static void AddMedicine(string name, decimal price, int count)
        {
            if(Validation.Test(name) && Validation.Test(price) && Validation.Test(count) && Pharmacy.Contains(name))
            {
                Medicine.Name = name;
                Medicine.Price = price;
                Medicine.Count = count;
                object med1 = new
                {
                    name = name,
                    price = price,
                    count = count
                };
                Pharmacy.medicines.Add(med1);
                Pharmacy.name.Add(name);
                Pharmacy.price.Add(price);
                Pharmacy.count.Add(count);
                Console.WriteLine("Medicine added.");
            }
            else
            {
                Console.WriteLine("Wrong acces.");
            }
        }
        public static void FindMedicineByName(string name) 
        {
            for(int i=0; i<medicines.Count; i++)
            {
                if (name == Pharmacy.name[i])
                {
                    Console.WriteLine(Pharmacy.medicines[i]);
                }
            }
            foreach(var item in Pharmacy.name)
            {
                if(name!=item)
                {
                    Console.WriteLine("Not found.");
                }
            }
        }
        public static void Sell(string name, int sellcount)
        {
            foreach(var item in Pharmacy.name)
            {
                if(name==item)
                {
                    for(int i=0; i<medicines.Count;i++)
                    {
                        if (name == Pharmacy.name[i])
                        {
                            Pharmacy.count[i]-= sellcount;
                            decimal amount = sellcount * Pharmacy.price[i];
                            Pharmacy.Amount= amount;
                            Pharmacy.TotalInCome += amount;
                            Console.WriteLine("Amount: "+amount);
                        }
                    }
                }
                else if (name != item)
                {
                    Console.WriteLine("Medicine not found");
                }
            }
        }
        public static void TotalInComes()
        {
            Console.WriteLine("Total in comes:"+Pharmacy.TotalInCome);
        }
        public static void MedicinesDisplay()
        {
            foreach (var item in medicines)
            {
                Console.WriteLine(item);
            }
        }
    }
}
