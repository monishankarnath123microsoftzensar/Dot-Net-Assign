using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollection
{
    class DictionaryCollection
    {
        static void Main()
        {
            ArrayList myArr = new ArrayList();
            Hashtable ht = new Hashtable();
            ht.Add(1,"one");
            ht.Add(2, "two");
            ht.Add("two", 15.67);
            ht.Add('c', "Cochain");
            ht.Add('m', "Cochain");

            IDictionaryEnumerator ide = ht.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine("{0}: {1}",ide.Key,ide.Value);
            }


            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("{0}-{1}",de.Key, de.Value);
            }
            Console.WriteLine("============Eg of Contains============");
            Console.WriteLine(ht.Contains('m'));
            Console.WriteLine("============Eg of Contains key============");
            Console.WriteLine(ht.ContainsKey("two"));
            Console.WriteLine("============Eg of Contains value============");
            Console.WriteLine(ht.ContainsValue(2));
            Console.WriteLine("============Eg of CopyTo============");
            DictionaryEntry[] mrr = new DictionaryEntry[ht.Count];
            ht.CopyTo(mrr, 0);
            for (int i = 0; i < mrr.Length; i++)
            {
                Console.WriteLine(mrr[i].Key + " --> "
                                  + mrr[i].Value);
            }
            // Maam's Code
            //Array arrObj = new Object[ht.Count];
            //ht.CopyTo(arrObj, 0);
            //Console.WriteLine("Values after copying ht data into arrObj");
            //foreach (DictionaryEntry item in arrObj)
            //{
            //    Console.WriteLine(item.Key + ":" + item.Value);

            //}
            Console.WriteLine("============Eg of key properties============");
            Console.WriteLine("Display keys");
            ICollection allKeys = ht.Keys;
            foreach(var v in allKeys)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("============Eg of value properties============");
            Console.WriteLine("Display Values");
            ICollection allVal = ht.Keys;
            foreach (var v in allVal)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("++++++++++++Sorted List++++++++++++");//sort in respect to keys
            SortedList slt = new SortedList();
            slt.Add("one", "One");
            slt.Add("two", "two");
            slt.Add("three", "Onetwo");
            slt.Add("Four", "Onethree");
            slt.Add("five", "five");
            foreach(DictionaryEntry it in slt)
            {
                Console.WriteLine(it.Key+" "+it.Value);
            }
            IList il = slt.GetValueList();
            Console.WriteLine("Values short listed");
            foreach(var it in il)
            {
                Console.WriteLine(it);
            }
            Console.WriteLine("Generics");
            ArrayList mylist = new ArrayList();
            mylist.Add(15);//boxing
            mylist.Add(25);
            mylist.Add(75);
            mylist.Add(12);
            //mylist.Add("Heloo");//casting
            mylist.Add(14);
            mylist.Add(15);
            foreach(int res in mylist)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("Use Of Generics collection list similar to Arraylist");
            List<int> list = new List<int>();
            list.Add(56);
            list.Add(14);//no boxing hence improve coding and less pressure on compiler
            List<string> slist = new List<string>();
            slist.Add("Hello");
            int findRes = list.Find(x => x.Equals(14));
            Console.WriteLine(findRes);
            List<int> findAll = list.FindAll(a => a != 56);
            Console.WriteLine("Find all 56");
            foreach(var it in findAll)
            {
                Console.WriteLine(it);
            }
           
        }
    }
}
