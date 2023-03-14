using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Enter Num here");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("given num is even");
            }
            else
            {
                Console.WriteLine("given num is odd");
            }
        }
    }
}
