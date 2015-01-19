using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1___Basic_Programming_Model
{
    class Basics
    {
        public static int MaximumOfArrayValues(int[] intArray)
        {
            int max = intArray[0];

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > max) max = intArray[i];
            }

            return max;
        }

        public static double AverageOfArrayValues(double[] dArray)
        {
            double sum = 0;
            double average;

            for (int i = 0; i < dArray.Length; i++)
            {
                sum += dArray[i];
            }

            average = sum / dArray.Length;

            return average;
        }

        
        public static string[] CopyToAnotherArray(string[] oldArray)
        {
            string[] newArray = new string[oldArray.Length];

            for (int i = 0; i < oldArray.Length; i++)
			{
                newArray[i] = oldArray[i];
			}

            return newArray;
        }
                
        
    }
}
