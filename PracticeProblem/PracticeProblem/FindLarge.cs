using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class FindLarge
    {
        //C# Program to Find the Largest of Two Numbers
        public static void CheckLargestNum()
        {
            Console.WriteLine("Enter First Num Here");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Num Here");
            int num2=Convert.ToInt32(Console.ReadLine());
            int result = Math.Max(num1, num2);
            Console.WriteLine("largest num is : " + result);
        }
    }
}
