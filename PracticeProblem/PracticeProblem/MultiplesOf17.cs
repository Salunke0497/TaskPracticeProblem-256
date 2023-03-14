using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class MultiplesOf17
    {
        //C# Program to Print All the Multiples of 17 which are Less than 100

        public static void CheckMultiplesOf17()
        {
            Console.WriteLine("the nums multiples of 17 : ");
            for (int i=0; i<=100; i++)
            {
                if(i%17==0)
                Console.WriteLine(i);
            }
        }
    }
}
