using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection coll = new int[] { 6, 5, 7, 8 };
            Array a1 = Array.CreateInstance(typeof(int), 4);
            ArrayList arr = new ArrayList();
            arr.AddRange(coll);
            arr.Add(5);//add at the end of the array//Boxing happening
            arr.Insert(0, 4);//Boxing happening

            foreach (var a in arr) //we can pass those object which directly or indirectly implement IEnumarable
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Capacity " + arr.Capacity);
            ArrayList ObjClone = (ArrayList)arr.Clone();//clone method return an object
            foreach(var c1 in ObjClone)
            {
                Console.WriteLine(c1);
            }

            Console.WriteLine("==================Assignment============");
            Console.WriteLine("=======Eg of Contain======");
            Console.WriteLine(arr.Contains(5));
            Console.WriteLine("=======Eg of Copyto======");

            Array arrTarget = new int[arr.Count];
            arr.CopyTo(arrTarget, 0);
            foreach (var v in arrTarget)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("=======Eg of Count======");
            Console.WriteLine(arr.Count);
            Console.WriteLine("=======Eg of Indexof======");
            Console.WriteLine(arr.IndexOf(6));
            Console.WriteLine("=======Eg of last IndexOf======");
            Console.WriteLine(arr.LastIndexOf(5));
            Console.WriteLine("=======After Sorting======");
            arr.Sort();
            foreach(var v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("=======Eg of InsertRange======");
            ICollection c = new int[] { 14, 12, 10};
            arr.Insert(2, 88);
            arr.InsertRange(7, c);
            foreach (var v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("=======Eg of GetRange======");
            ArrayList getR = arr.GetRange(2, 6);
            foreach(var it in getR)
            {
                Console.WriteLine(it);
            }
            Console.WriteLine("=======Eg of Reverse======");
            arr.Sort();
            arr.Reverse();
            foreach (var v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("=======Eg of Remove======");
            arr.Remove(14);
            Console.WriteLine("After removing 14");
            foreach (var v in arr)
            {
                Console.WriteLine(v);
            }
            
            Console.WriteLine("=======Eg of RemoveAt======");
            arr.RemoveAt(3);
            Console.WriteLine("After removing from index 3");
            foreach (var v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("=======Eg of GetRange======");
            arr.RemoveRange(2,2);
            Console.WriteLine("After removing from index 2 and count 2");
            foreach (var v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Viewing the contents of the array list using GetEnumarator");

            IEnumerator en = arr.GetEnumerator();//itreate through array just like foreach with the help of GetEnumerator
            while(en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
            Console.WriteLine("=======Eg of clear======");
            arr.Clear();

        }
    
    }
}
