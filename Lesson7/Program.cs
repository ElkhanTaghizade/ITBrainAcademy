using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Student Class
            //string[] group114={"Elxan","Ilkin","Nesir","Ehliman"};

            //Student student1 =new Student();

            //Console.WriteLine("Enter your fullname:");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("Enter your group no:");
            //int groupNo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your age:");
            //byte age = Convert.ToByte(Console.ReadLine());
            //student1= new Student();
            //student1.Fulllname= fullname;
            //Console.WriteLine("Fullname:"+student1.Fulllname);
            //student1.GroupNo = groupNo;
            //Console.WriteLine("Group No:"+student1.GroupNo);
            //student1.Age = age;
            //Console.WriteLine("Age:"+student1.Age);
            //if(groupNo==114)
            //{
            //    Console.WriteLine("Number of people in the group:" + Count(group114));
            //}
            //else if(groupNo==115)
            //{
            //    Console.WriteLine("Number of people in the group:"+5);
            //}
            //else
            //{
            //    Console.WriteLine("Group not found.");
            //}
            //student1.GetBirthYear(age);
            #endregion

            #region Account Class
            Hashtable users= new Hashtable();
            string user11="";
            string password11="";
            Account account = new Account(users, user11, password11);

            bool check = true;
            while (check)
            {
                Console.WriteLine("");
                Console.WriteLine("To add: 1");
                Console.WriteLine("To display the list: 2");
                Console.WriteLine("Exit: 3");
                string button = Console.ReadLine();
                switch (button)
                {
                    case "1":
                        Console.WriteLine("Enter your username:");
                        object username = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        object password = Console.ReadLine();
                        Account account1 = new Account(users, account.IsUserNameValid(username),account.IsPasswordValid(password));
                        Console.WriteLine("Items added.");


                        break;

                   case "2":
                        foreach(var item in users.Keys)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "3":
                        check = false;

                        break;

                    default: Console.WriteLine("Wrong button.");

                        break;
                }
            }
            #endregion
        }
        static int Count(string [] group)
        {
            int Count = 0;
            for(int i=0; i<group.Length; i++)
            {
                Count++;
            }
            return Count; 
        }

    }
    public class Student
    {
        public void GetBirthYear(int old)
        {
            int year1;
            year1 = 2023 - old;
            Console.WriteLine("Birth Year:"+year1);
        }
        public string Fulllname { get; set; }
        public int GroupNo { get; set; }
        public int Age { get; set; }

    }
    public class Account
    {
        public Account (Hashtable users1, string username1, string password1)
        {
            users1.Add(username1,password1);
            
        }
        public string IsUserNameValid(string username)
        {
            for(int i=0; i<username.Length;)
            {

            }
            return username;
           
        }
        public string IsPasswordValid(string password)
        {
            if(password.Length>8 && password.Length<25)
            {
                return password;

            }
            else
            {
                return "Enter a password of length between 8 and 25.";
            }
        }



    }
}
