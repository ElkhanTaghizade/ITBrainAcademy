using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Odd and Even
            //List<int> nums= new List<int>();
            //Console.WriteLine("How many numbers will you add?");
            //int times=Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < times; i++)
            //{
            //    Console.WriteLine("Enter the numbers:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    nums.Add(num);
            //}
            //Console.WriteLine("Is it just odd numbers?  "+ExtentionMethods.IsOdd(nums));
            //Console.WriteLine("Is it just even numbers?  " + ExtentionMethods.IsEven(nums));
            //if (ExtentionMethods.IsOdd(nums) == false && ExtentionMethods.IsEven(nums) == false)
            //{
            //    Console.WriteLine("Are there both evens and numbers?   Yes");
            //}
            #endregion
            #region Contains Digit
            //Console.WriteLine("Enter word:");
            //string word=Console.ReadLine();
            //Console.WriteLine("Are there digit characters?"+ExtentionMethods.IsContainsDigit(word));
            #endregion
            #region GetValueINdexes1
            //Console.WriteLine("Enter word");
            //string word=Console.ReadLine();
            //Console.WriteLine("Enter element:");
            //char element=Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Indexes of element:");
            //ExtentionMethods.GetValueIndexes1(word, element);
            #endregion
            #region GetValueINdexes2
            int[] nums = { 1, 3, 5, 8, 10, 15, 18, 20, 38, 50 };
            Console.WriteLine("Enter element:");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indexes of element:");
            ExtentionMethods.GetValueIndexes2(nums, element);
            #endregion
        }
    }
    public static class ExtentionMethods
    {
        public static bool IsOdd(List<int> number)
        {
            bool IsOdd = false;
            foreach(int item in number)
            {
                if (item % 2 == 1)
                {
                    IsOdd = true;
                }
                else
                {
                    IsOdd = false;
                }
            }
            if (IsOdd == true && IsOdd == false)
            {
                return false;
            }
            else if(IsOdd != false && IsOdd == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEven(List<int> number)
        {
            bool IsEven = false;
            foreach (int item in number)
            {
                if (item % 2 == 0)
                {
                    IsEven = true;
                }
                else
                {
                    IsEven = false;
                }
            }
            if (IsEven == true && IsEven == false)
            {
                return false;
            }
            else if (IsEven != false && IsEven == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsContainsDigit(string word)
        {
            bool IsContainsDigit = false;
            foreach (char item in word)
            {
                if((int)item>=48 && (int)item<=57)
                {
                    IsContainsDigit= true;
                }
                if(IsContainsDigit==true)
                {
                    return true;
                }
            }
            return false;
        }
        public static void GetValueIndexes1(string word, char element)
        {
            int[] indexes = { };
            int count = 0;
            for(int i=0; i<word.Length;i++)
            {
                if (word[i] == element)
                {
                    count++;
                    indexes = indexes.Append(i).ToArray();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Not found");
            }
            foreach (var item in indexes)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetValueIndexes2(int[] array, int element)
        {
            int[] nums = {};
            int count = 0;
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] == element)
                {
                    count++;
                    nums= nums.Append(i).ToArray();
                }
            }
            if(count==0)
            {
                Console.WriteLine("Not found");
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
