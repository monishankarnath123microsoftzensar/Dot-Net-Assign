using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_08_2020
{
    class LinkedListAssign
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
            Console.WriteLine("=============AddFirst===============");
            lList.AddFirst("The");
            
            foreach (var stu in lList)
            {
                Console.WriteLine(stu+" ");
            }
            Console.WriteLine("=============AddLast===============");
            lList.AddLast("fox.");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu + " ");
            }
            Console.WriteLine("=============AddAfter & find===============");
            
            lList.AddAfter(lList.Find("quick"),"brown");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu + " ");
            }
            Console.WriteLine("=============AddBefore & Findlast===============");

            lList.AddBefore(lList.FindLast("the"), "jumps over");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu + " ");
            }
            Console.WriteLine("=============Final Output===============");
            
            foreach (var stu in lList)
            {
                Console.Write(stu + " ");
            }


            Console.Read();
        }
    }
}
