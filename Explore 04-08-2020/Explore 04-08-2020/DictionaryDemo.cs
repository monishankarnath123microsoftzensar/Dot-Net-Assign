using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_04_08_2020
{
    class DictionaryDemo
    {
        static void Main()
        {
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(1, "Monishankar");
            di.Add(2, "Smriti");
            di.Add(3, "Dipansh");
            di.Add(4, "Dipanjan");
            di.Add(5, "Anshul");
            Console.WriteLine("-------------Dictionary Element--------------------");
            foreach (var a in di)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===============Count===============");
            Console.WriteLine("Count of element in dictionary : {0}", di.Count);
            Console.WriteLine("===============Contains Key===============");
            Console.WriteLine("Checking index 2 in di : {0}", di.ContainsKey(2));
            Console.WriteLine("===============Contains Value===============");
            Console.WriteLine("Checking Value Anshul in di : {0}", di.ContainsValue("Anshul"));
            Console.WriteLine("===============Clear===============");
            Console.WriteLine("Removing All element From di : ");
            di.Clear();

            foreach (var a in di)
            {
                Console.WriteLine(a);
            }


            Console.ReadLine();

        }
    }
}
