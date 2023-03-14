using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class ReverseNum
    {
        public static void CheckReverseNum()
        {
            Console.WriteLine("Enter Number Here To reverse");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reverseArray = new string(chars);
            Console.WriteLine("Reverse number : " + reverseArray);
        }
    }
}
