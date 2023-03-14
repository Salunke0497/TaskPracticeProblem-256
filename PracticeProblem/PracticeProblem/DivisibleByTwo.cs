using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class DivisibleByTwo
    {
        public static void CheckDivisible()
        {
            Console.WriteLine("Enter Num Here");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("given num is divisible by 2");
            }
            else
            {
                Console.WriteLine("Given num is not divible 2");
            }
        }
    }
}
