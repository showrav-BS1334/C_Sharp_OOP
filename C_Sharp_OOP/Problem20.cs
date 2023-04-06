using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP
{
    internal class Problem20
    {
        public void Solve()
        {
            int[] intArray = new int[] { 1, -7, 5, 2 };
            double[] doubleArray = new double[] { 1.2, 4, 5.221 };
            string[] stringArray = new string[] { "zoo", "ice", "apple", "football" };

            // type
            Console.WriteLine(intArray.GetType());

            // sort and reverse
            Array.Sort(stringArray);
            Array.Reverse(stringArray);
            foreach (string word in stringArray)
            {
                Console.WriteLine(word);
            }
            
            // setting initial value(0 for numeric types!)
            Array.Clear(doubleArray);
            foreach(double doubleNum in doubleArray)
            {
                Console.WriteLine(doubleNum);
            }
            Console.WriteLine("\n-----------------------");
            int[] newIntArray = new int[5];
            Array.Copy(intArray, newIntArray, 3);
            foreach(int intNum in newIntArray)
            {
                Console.WriteLine(intNum);
            }
        }
    }
}
