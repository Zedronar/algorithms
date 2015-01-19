using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1___Basic_Programming_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreatestCommonDivisor.GCD(10, 6));

            Console.WriteLine(Basics.MaximumOfArrayValues(new int[] {1, 2, 3, 4}));

            Console.WriteLine(Basics.AverageOfArrayValues(new double[] {10, 20, 30}));

            Console.WriteLine(Basics.CopyToAnotherArray(new string[] {"copy", "this", "please"}));
        }
    }
}
