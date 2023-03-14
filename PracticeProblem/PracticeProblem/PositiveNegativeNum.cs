using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class PositiveNegativeNum
    {
        public static void CheckPositiveNum()
        {
            Console.WriteLine("Enter Num Here");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("given num is positive num");
            }
            else
            {
                Console.WriteLine("Given num is negative num");
            }
        }
    }
}
