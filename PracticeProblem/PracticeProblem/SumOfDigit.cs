using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class SumOfDigit
    {
        public static void CheckSum()
        {
            Console.WriteLine("Enter num here");
            string num = Console.ReadLine();
            int num1 = 0;
            foreach(var i in num)
            {
                int num2 = Convert.ToInt32(i.ToString());
                num1 += num2;              
            }
            Console.WriteLine("The addition of enterd number is : " + num1);
        }
    }
}
