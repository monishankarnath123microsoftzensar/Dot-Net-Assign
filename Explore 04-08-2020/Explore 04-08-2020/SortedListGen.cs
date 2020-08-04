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

            SortedList<int, string> sl1 = new SortedList<int, string>();
            sl1.Add(3, "Three");
            sl1.Add(1, "One");
            sl1.Add(2, "Two");
            sl1.Add(4, null);
            IList il = sl1.GetValueList();
            Console.WriteLine("Values short listed");
            foreach (var it in il)
            {
                Console.WriteLine(it);
            }

        }
    }
}
