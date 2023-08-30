using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your email:");
            string email=Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            User user=new User(email, password);
            Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            string surname =Console.ReadLine();
            user.ShowInfo(name, surname, email);
        }
    }
    public abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public virtual void ShowInfo(string name, string surname, string email) { }
        public Account(string email1, string pasword1) { }
    }
    public class User : Account
    {
        public string Fullname(string name, string surname) 
        {
            string name1 = name;
            string surname1 = surname;
            string fullname = name1 + surname1;
            return fullname;
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public override bool PasswordChecker(string password)
        {
            bool PasswordChecker=false;
            bool lowc = false;
            bool upc = false;
            for(int i=0; i<password.Length; i++)
            {
                if ((int)password[i]>=65 && (int)password[i]<=90)
                {
                    upc = true;
                }
                if ((int)password[i] >= 97 && (int)password[i] <= 122)
                {
                    lowc = true;
                }
            }
            if(lowc==true && upc==true && password.Length>=8)
            {
                PasswordChecker = true;
            }
            return PasswordChecker;
        }
        public User(string email, string password): base(email,password)
        {
           if(PasswordChecker(password)==true)
            {
                Email= email;
                Password= password;
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
        public override void ShowInfo(string name, string surname, string email)
        {
            Console.WriteLine($"Fullname:{Fullname(name,surname)}  Email:{Email}");
        }
    }
}
    

