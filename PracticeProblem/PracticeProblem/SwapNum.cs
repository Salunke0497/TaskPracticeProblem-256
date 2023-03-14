using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class SwapNum
    {
        public static void CheckSwapNum()
        {
            int result;
            Console.WriteLine("Enter First Num Here");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Secound Num Here");
            int num2 = Convert.ToInt32(Console.ReadLine());
            result = num1;
            num1 = num2;
            num2 = result;
            Console.WriteLine("after swaping");
            Console.WriteLine(num1);
            Console.WriteLine(num2);

        }
    }
}
