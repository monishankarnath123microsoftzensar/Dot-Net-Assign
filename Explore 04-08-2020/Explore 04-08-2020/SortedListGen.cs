using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_04_08_2020
{
    class SortedListGen
    {
        static void Main()
        {

            SortedList<string, string> slist = new SortedList<string, string>();
            slist.Add("India", "MSDhoni");
            slist.Add("Australia", "RickyPonting");
            slist.Add("England", "KevinPeterson");
            slist.Add("Newzealand", "Williamson");
            slist.Add("SouthAfrica", "ABDvillers");
            Console.WriteLine("*******Remove******");
            slist.Remove("England");
            Console.WriteLine("list after removing");
            foreach (var item in slist)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.WriteLine("********Index of key*******");
            Console.WriteLine("Index of key india is :{0}", slist.IndexOfKey("India"));
            Console.WriteLine("************Index of value**********");
            Console.WriteLine("Index of Value is :{0}", slist.IndexOfValue("MSDhoni"));

            Console.WriteLine("********containskey*********");
            Console.WriteLine(slist.ContainsKey("India"));
            Console.WriteLine("******containsvalue********");
            Console.WriteLine(slist.ContainsValue("MSDhoni"));
            Console.WriteLine("***********Get Value*********");
            Console.WriteLine(slist.TryGetValue("India", out _));
            Console.WriteLine("***********Remove at*********");
            slist.RemoveAt(3);
            Console.WriteLine("after removing 4th index");
            foreach (var item in slist)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            IEnumerator<KeyValuePair<string, string>> ie = slist.GetEnumerator();
            Console.WriteLine("Display");
            while (ie.MoveNext())
            {
                Console.WriteLine("{0} : {1}", ie.Current.Key, ie.Current.Value);
            }
        }
    }
}
