using System;
using System.Collections.Generic;
using System.Linq;

namespace ConPartial
{
    class ListExten
    {
        static void Main()
        {
            List<string> lstr = new List<string>(new string[] { "Moni", "Dustu", "samiran", "subhojit" });
            List<string> lstr2 = new List<string>(new string[] { "Shakar", "SNath", "Dustuuu", "Smriti" });
            List<int> lstr3 = new List<int>(new int[] { 1, 25, 74, 5, 12 });
            foreach (var l in lstr)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("============Concat============");
            var res = lstr.Concat(lstr2);
            //List<string> resultList = res.ToList();
            foreach (var entry in res)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("============First============");
            Console.WriteLine(lstr.First());
            Console.WriteLine(lstr2.First(x => x.Length == 7));
            Console.WriteLine("============FirstOrDefault============");
            Console.WriteLine(lstr.FirstOrDefault(x => x.Length == 5));
            Console.WriteLine("============All============");
            Console.WriteLine(lstr2.All(a => a.StartsWith("S")));
            Console.WriteLine("============Average============");
            Console.WriteLine(lstr3.Average());
            Console.WriteLine(lstr.Average(s => s.Length));
            Console.WriteLine("============Any============");
            Console.WriteLine("Is List Not Emplty " + lstr2.Any());
        }
    }
}
