using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_04_08_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(54);
            list.Add(24);
            list.Add(24);
            list.Add(24);
            list.Add(55);
            Console.WriteLine("==============FindIndex==============");
            Console.WriteLine(list.FindIndex(x => x == 55));
            Console.WriteLine("==============FindLast==============");
            Console.WriteLine(list.FindLast(x => x.Equals(24)));
            Console.WriteLine("==============FindLastIndex==============");
            Console.WriteLine(list.FindLastIndex(x => x.Equals(24)));
            Console.WriteLine("==============FindAll==============");
            List<int> findAll = list.FindAll(x => x.Equals(24));
            Console.WriteLine("Find all 24");
            foreach (var it in findAll)
            {
                Console.WriteLine(it);
            }

        }
    }
}
