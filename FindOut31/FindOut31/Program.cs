using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOut31
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            Console.Write("First array elements: ");
            foreach (var dis1 in arr)
            {
                Console.Write(dis1 + " ");
            }
            int[] arr2 = new int[6];
            // Displaying length of array  
            Console.WriteLine("\nlength of first array: " + arr.Length);
            // Sorting array  
            Array.Sort(arr);
            Console.Write("First array elements after sorting: ");
            // Displaying sorted array  
            foreach (var dis2 in arr)
            {
                Console.Write(dis2 + " ");
            }
            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
            // Coping first array to empty array  
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("Second array elements: ");
            // Displaying second array  
            foreach (var dis3 in arr2)
            {
                Console.Write(dis3 + " ");
            }
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            foreach (var dis4 in arr)
            {
                Console.Write(dis4 + " ");
            }
            Console.WriteLine("\n=========================String Builder====================");
            // "20" is capacity 
            StringBuilder s = new StringBuilder("HELLO ", 20);

            s.Append("\nGFG");

            // after printing "GEEKS" 
            // a new line append 
            s.AppendLine("GEEKS");

            s.Append("GeeksForGeeks");
            Console.WriteLine(s);

            s.Remove(5, 3);

            Console.WriteLine("\nAfter remove \n"+s);

            s.Replace("G", "Geeks ");

            Console.WriteLine("\nReplace \n"+s);

            s.Insert(6, "GEEKS");

            Console.WriteLine("\nInsert \n" + s);
        }
        
    }
}
