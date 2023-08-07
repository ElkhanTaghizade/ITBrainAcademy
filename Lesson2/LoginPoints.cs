using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                 Welcome to the system...");
            Console.WriteLine("Enter your points to login.");
            Console.WriteLine("Enter your first score:");
            byte score1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter your second score:");
            byte score2 = Convert.ToByte(Console.ReadLine());
            byte score = score1 + score2;
            if(score>=90 && score<=100)
            {
                Console.WriteLine("Your grade is A.");
                Console.ReadLine();
            }
            else if(score>=80 && score<=89)
            {
                Console.WriteLine("Your grade is B.");
                Console.ReadLine();
            }
            else if(score>=70 && score<=79)
            {
                Console.WriteLine("Your grade is C.");
                Console.ReadLine();
            }
            else if(score>=60 && score<=69) 
            {
                Console.WriteLine("Your grade is D.");
                Console.ReadLine();
            }
            else if(score>=0 && score<=59)
            {
                Console.WriteLine("Your grade is F.");
                Console.ReadLine();
            }
            else if(score<0 || score>100)
            {
                Console.WriteLine("Your score does not match the system.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You pressed wrong button. ");
                Console.ReadLine();
            }

        }
    }
}
