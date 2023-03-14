using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class OddNumRange
    {
        public static void CheckRange()
        {
            Console.WriteLine("Enter first num for range");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secound num for range");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i =x; i <=y; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i + " : given num is even");
                }
                else
                {
                    Console.WriteLine(i + " : given num is odd");
                }
            }
        }
    }
}
