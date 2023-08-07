using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Csharp_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Numbers Array
            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };

            int maxNum = numbers[0];
            int minNum = numbers[0];
            int result = 0;
           foreach(var item in numbers)
            {
                if(item>maxNum)
                {
                    maxNum = item;
                }
                if(item<minNum)
                {
                    minNum = item;
                }
            }
           for (int i = 0; i<numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            Console.WriteLine("Max number:"+maxNum);
            Console.WriteLine("Min number:"+minNum);
            Console.WriteLine("Result:" + result);
            Console.ReadLine();
            //int count=0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]==9)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"9 repeated {count} times.");
            //Console.ReadLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] >= 10 && numbers[i] <= 30)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region Multiplication Table

            //int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Public  Multipllication Table
            //int number1;
            //int number2;
            //for(int i=0; i<numbers2.Length; i++)
            //{
            //   number1= numbers2[i];

            //    for(int j=0; j<numbers2.Length; j++)
            //    {
            //        number2 = numbers2[j];
            //        Console.WriteLine($"{number1}*{number2}="+number1 * number2);
            //    }
            //}
            //Console.WriteLine("Enter the number:");
            //int figure=Convert.ToInt32(Console.ReadLine());
            //for(int i= 0; i < numbers2.Length;i++)
            //{
            //    Console.WriteLine($"{figure}*{numbers2[i]}=" + figure * numbers2[i]);
            //}

            //Console.ReadLine();
            #endregion


            #region Calculator (with Switch Case)
            //Console.WriteLine("                                                Calculator");
            //Console.WriteLine("Enter first number:");
            //int number1=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //int number2=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the symbol");
            //string symbol = Console.ReadLine();

            //switch (symbol)
            //{

            // case "+" :
            //    Console.WriteLine(number1+number2);
            //        break;
            // case "-" :
            //        Console.WriteLine(number2-number1);
            //        break;
            // case "*" :
            //        Console.WriteLine(number2 * number1);
            //        break;
            // case "/" :
            //        Console.WriteLine(number2 / number1);
            //        break;
            //}
            //Console.ReadLine();

            #endregion
            #region Library Book Inventory Management

            //Console.WriteLine();

            //string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            //string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            //string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            //int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };
            //Console.WriteLine("Type all to display the list");
            //string list = Console.ReadLine();
            //Console.WriteLine("Enter the name of the book you are looking for:");
            //string book = Console.ReadLine();

            //for (int i = 0; i < bookTitles.Length; i++)
            //{
            //    for (int j = 0; j < bookAuthors.Length; j++)
            //    {
            //        for (int k = 0; k < bookGenres.Length; k++)
            //        {
            //            for (int c = 0; c < bookCopiesAvailable.Length; c++)
            //            {
            //                if (j == i && i == k && k == c)
            //                {

            //                    if (list == "all")

            //                    {
            //                        Console.WriteLine($"There are {bookCopiesAvailable[c]} pieces from the book {bookTitles[i]} in the {bookGenres[k]} genre whose author is {bookAuthors[j]}.");
            //                        break;
            //                    }
            //                    if (book == bookTitles[i])
            //                    {
            //                        Console.WriteLine($"There are {bookCopiesAvailable[c]} copies of the book you are looking for");
            //                    }
            //                    else if (book != bookTitles[i])
            //                    {
            //                        if (i == 1)
            //                        {
            //                            Console.WriteLine("The copy of the book you are looking for is not available");
            //                        }
            //                    }
            //                }

            //            }
            //        }


            //    }
            //}
            //Console.ReadLine();


            #endregion 
        }








    }
}
