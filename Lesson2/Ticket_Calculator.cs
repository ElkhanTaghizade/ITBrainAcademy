using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                             Welcome to Ticket Calculator");
            Console.WriteLine("Enter your age:");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the day of the week:");
            string day = Console.ReadLine();
            if (day == "Monday" || day == "monday" || day == "Tuesday" || day == "tuesday" || day == "Thursday" || day == "thursday" || day == "friday" || day == "Friday" || day == "saturday" || day == "Saturday" || day == "Sunday" || day == "sunday")
            {
                if (age>=0 && age<=12)
                {
                    Console.WriteLine("Enter your age:"+age);
                    Console.WriteLine("Enter the day of the week:"+day);
                    Console.WriteLine("Your ticket price is 5$.");
                    Console.ReadLine();
                }
                else if(age>=13 && age<=64)
                {
                    Console.WriteLine("Enter your age:" + age);
                    Console.WriteLine("Enter the day of the week:" + day);
                    Console.WriteLine("Your ticket price is 10$.");
                    Console.ReadLine();
                }
                else if(age>=65)
                {
                    Console.WriteLine("Enter your age:" + age);
                    Console.WriteLine("Enter the day of the week:" + day);
                    Console.WriteLine("Your ticket price is 7$.");
                    Console.ReadLine();
                }
                else if (age < 0)
                {
                    Console.WriteLine("Enter your age correctly.");
                    Console.ReadLine();
                }
            }
            else if (day == "Wednesday" || day == "wednesday")
            {
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine("Enter your age:" + age);
                    Console.WriteLine("Enter the day of the week:" + day);
                    Console.WriteLine("Your ticket price is 3$.");
                    Console.ReadLine();
                }
                else if (age >= 13 && age <= 64)
                {
                    Console.WriteLine("Enter your age:" + age);
                    Console.WriteLine("Enter the day of the week:" + day);
                    Console.WriteLine("Your ticket price is 8$.");
                    Console.ReadLine();
                }
                else if (age >= 65)
                {
                    Console.WriteLine("Enter your age:" + age);
                    Console.WriteLine("Enter the day of the week:" + day);
                    Console.WriteLine("Your ticket price is 5$.");
                    Console.ReadLine();
                }
                else if (age < 0)
                {
                    Console.WriteLine("Enter your age correctly.");
                    Console.ReadLine();
                }
            }

            else
            {
                Console.WriteLine("Wrong spelling");
                Console.ReadLine();
            }

        }
    }
}
