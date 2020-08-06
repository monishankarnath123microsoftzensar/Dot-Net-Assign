using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOFileHandle
{
    class ForLoopAssign
    {
        static void Main()
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 5, 0, 3 };

            for (int i = 0; i < arr1.Length; i++)
            {
                try
                {
                    Console.WriteLine($"{arr1[i]} {arr1[i] / arr2[i]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{arr1[i]} {ex.Message}");
                }
            }
        }

    }
}
