using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion" };
            string[] Animal = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] place = { "Africa", "New Zealand", "Jamaica", "India" };
            Console.WriteLine("===========For Loop============");
            for(int i=0; i<MyArray.Length;i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.WriteLine("===========Foreach Loop============");
            foreach (string i in MyArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===========doWhile Loop============");
            int m=0;
            do
            {
                Console.WriteLine(MyArray[m]);
                m++;

            } while (m < MyArray.Length);
            Console.WriteLine("===========While Loop============");
            m = 0;
            while (m < MyArray.Length)
            {
                Console.WriteLine(MyArray[m]);
                m++;
            }
            Console.WriteLine("===========Sorted Array============");
            Array.Sort(MyArray);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Array.Sort(Animal);
            Array.Sort(place);
            Console.WriteLine("===========Sorted Array Animal============");
            foreach (string i in Animal)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===========Sorted Array Place============");
            foreach (string i in place)
            {
                Console.WriteLine(i);
            }

        }
    }
}
