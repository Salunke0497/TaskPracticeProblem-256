using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    //C# Program to Reverse a Number and Check if it is a Palindrome

    public class ReverseAndCheckPalindrom
    {
        public static void CheckReverseAndPalindrom()
        {
            Console.WriteLine("Enter Number Here To reverse");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reverseNum = new string(chars);
            Console.WriteLine("Reverse number : " + reverseNum);

            //check for Plindrom num
            if (input == reverseNum)
                Console.WriteLine("Enterd Num is Palindrom");
            else
                Console.WriteLine("Entered Num is not Palindrom");
        }
    }
}
