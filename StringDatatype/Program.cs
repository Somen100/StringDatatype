using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Reverse a string ");
            Console.WriteLine("***************1st Qn:Reverse a string");
            Console.WriteLine("Enter your string");

            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            for (int i = charArray.Length; i >0; i--)
            {
                Console.Write(charArray[i-1]);
            }


            // Console.WriteLine("find length of a string");

            Console.WriteLine(" *************** 2nd qn: find length of a string");
            Console.WriteLine("Enter your string");
            string word2 = Console.ReadLine();
            int count = 0;
            foreach (char c in word2)
            {
                count++;
            }
            Console.WriteLine(count);

            // Console.WriteLine("find length of a string using count function");
            Console.WriteLine(" *************** 3rd qn: find length of a string using count function");
            Console.WriteLine("Enter your string");
            string word3 = Console.ReadLine();
            int count2 = 0;
            count2 = word3.Count();
            Console.WriteLine("length using count function: "+ count2);

            // Console.WriteLine(" Replace a string");
            Console.WriteLine(" *************** 4th qn: Replace a string");
         
            string word4 = "Sun Rises in the West  ";
            Console.WriteLine(word4 + "/n");
            string replacedWord = word4.Replace("West", "East");
            
            Console.WriteLine("Replaced string: " + replacedWord);

            // Console.WriteLine("UpperCase to  Lowercase");
            Console.WriteLine("*************** 5th qn:UpperCase to  Lowercase");
            Console.WriteLine("Enter a string in Uppercase");
            string ucaseWord = Console.ReadLine();
            string lcaseWord = ucaseWord.ToLower();

            Console.WriteLine("lowercase string: " + lcaseWord);

            // Console.WriteLine("Find maximum occuring character in a string");
            Console.WriteLine("*************** 7th qn: sort a string array in ascending order.");
            Console.WriteLine("Enter a string to sort in ascending order");
            string str1 = Console.ReadLine();
            char[] spearator = { ',', ' ' };
            string[] names = str1.Split(spearator);
            
            Array.Sort(names);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

           
            Console.ReadLine();
        }
    }
}
