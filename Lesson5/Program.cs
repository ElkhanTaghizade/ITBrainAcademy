using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                    Online Bookstore System... ");
            Console.WriteLine("Enter your username to login to the system:");

            Hashtable user = new Hashtable();
            user.Add("elkhan123", "Elkhan Taghizade");
            user.Add("ilkin123", "Ilkin Novruzov");
            user.Add("nesir123", "Nasir Asadov");
            ArrayList keys= new ArrayList();
            keys.AddRange(user.Keys);
            object username=Console.ReadLine();
            int count1 = 0;
            foreach (object item in keys)
            {
                count1 = 1;
                if (username == item)
                {
                    Console.WriteLine("                                             Welcome to Bookstore...");
                    ArrayList title = new ArrayList();
                    title.Add("Title.1");
                    title.Add("Title.2");
                    title.Add("Title.3");
                    title.Add("Title.4");
                    ArrayList author = new ArrayList();
                    author.Add("Author.1");
                    author.Add("Author.2");
                    author.Add("Author.3");
                    author.Add("Author.4");
                    ArrayList price = new ArrayList();
                    price.Add(10);
                    price.Add(15);
                    price.Add(12);
                    price.Add(14);


                    Console.WriteLine("To view the book details: 1");
                    Console.WriteLine("To add a book: 2");
                    Console.WriteLine("To delete a book: 3");
                    Console.WriteLine("To calculate the total value of all books: 4");
                    Console.WriteLine("Exit: 5");
                    int choose = 0;
                    while (choose < 5)
                    {
                        int button = Convert.ToInt32(Console.ReadLine());
                        switch (button)
                        {
                            case 1:
                                for (int j = 1; j < title.Count; j++)
                                {
                                    Console.WriteLine($"{title[j]}:{author[j]}:{price[j]}");
                                }

                                break;

                            case 2:

                                Add(title,author,price);

                                Console.WriteLine("Book added.");
                                Console.WriteLine("***********************");
                                for (int j = 0; j < title.Count; j++)
                                {
                                    Console.WriteLine($"{title[j]}:{author[j]}:{price[j]}");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Write the title of the book");
                                object titlerem = Console.ReadLine();

                                Console.WriteLine("Write the author of the book");
                                object authorrem = Console.ReadLine();

                                Console.WriteLine("Write the price of the book");
                                object pricerem = Console.ReadLine();
                                int count = 0;
                                for (int k = 0; k < title.Count; k++)
                                {
                                    if (titlerem == title[k] && authorrem == author[k] && pricerem == price[k])
                                    {
                                        count=1;
                                        title.Remove(titlerem);
                                        author.Remove(authorrem);
                                        price.Remove(pricerem);
                                        Console.WriteLine("Book deleted.");
                                        Console.WriteLine("*************************");
                                        for (int j = 1; j < title.Count; j++)
                                        {
                                            Console.WriteLine($"{title[j]}:{author[j]}:{price[j]}");
                                        }
                                    }
                                   
                                }
                                 if(count== 0)
                                {
                                    Console.WriteLine("Book not found.");
                                }
                                break;

                            case 4:
                                Calc(price);

                                break;


                            case 5:
                                choose = 6;
                                Console.WriteLine("Exit...");
                                break;


                            default:
                                Console.WriteLine("Wrong button.");
                                break;
                        }
                    }

                } break;
                
                
            }
            if (count1==0)
            {
                Console.WriteLine("Wrong username.");
            }

        }
        public static void Calc(ArrayList result)
        {
            ArrayList arraylist1= new ArrayList();
            arraylist1.AddRange(result);

            int result1 = 0;
            int item;
            for(int p=0;p<arraylist1.Count;p++)
            {
                if (arraylist1[p] is int)
                {
                    item= (int)arraylist1[p];
                    result1 = result1 + item;
                }
            }
            Console.WriteLine("Total price:" + result1);

        }
        public static void Add(ArrayList title2, ArrayList author2, ArrayList price2 )
        {
            ArrayList title1= new ArrayList();
            title1.Add(title2);
            Console.WriteLine("Write the title of the book");
            string titleadd = Console.ReadLine();
            title1.Add(titleadd);
            title2.Add(title1);

            ArrayList author1= new ArrayList();
            author1.Add(author2);
            Console.WriteLine("Write the author of the book");
            string authoradd = Console.ReadLine();
            author1.Add(authoradd);
            author2.Add(author1);

            ArrayList price1 = new ArrayList();
            price1.Add(price2);  
            Console.WriteLine("Write the price of the book");
            string priceadd = Console.ReadLine();
            price1.Add(priceadd);
            price2.Add(price1);

        }

    }
}
