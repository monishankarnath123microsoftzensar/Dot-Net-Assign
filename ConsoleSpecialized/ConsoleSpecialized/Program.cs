using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ConsoleSpecialized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============StringCollection===========");
            String[] myArr = new String[] { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            StringCollection myCol = new StringCollection();
            myCol.Add("Apple");
            myCol.Add("Orange");
            myCol.Add("Mango");
            myCol.AddRange(myArr);
            foreach (var item2 in myCol)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("count of string collection: "+ myCol.Count);
            Console.WriteLine("CopyTo:=====");
            string[] str1 = new string[myCol.Count];
            myCol.CopyTo(str1, 0);
            foreach (var item1 in str1)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("contains method");
            Console.WriteLine(myCol.Contains("Mango"));
            Console.WriteLine("Insert: dear"); 
            myCol.Insert(5, "dear");
            StringEnumerator myEnumerator = myCol.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.WriteLine("{0}", myEnumerator.Current);
            Console.WriteLine();

            Console.WriteLine("============StringDictionary===========");
            StringDictionary myCol1 = new StringDictionary();
            myCol1.Add("red", "rojo");
            myCol1.Add("green", "verde");
            myCol1.Add("blue", "azul");
            Console.WriteLine("contains key red :{0}", myCol1.ContainsKey("red"));

            Console.WriteLine("containe value 'azul': {0}", myCol1.ContainsValue("azul"));


            Console.WriteLine("remove key------");
            myCol1.Remove("red");
            IEnumerator myEnumerator1 = myCol1.GetEnumerator();
            foreach (DictionaryEntry de in myCol1)
                Console.WriteLine("{0} {1}", de.Key, de.Value);
            Console.WriteLine();

            Console.WriteLine("============ListDictionary===========");
            ListDictionary myCol2 = new ListDictionary();
            myCol2.Add("Braeburn Apples", "1.49");
            myCol2.Add("Fuji Apples", "1.29");
            myCol2.Add("Gala Apples", "1.49");
            myCol2.Add("Golden Delicious Apples", "1.29");
            myCol2.Add("Granny Smith Apples", "0.89");
            myCol2.Add("Red Delicious Apples", "0.99");
            Console.WriteLine("CopyTo===============");
            DictionaryEntry[] myArr1 = new DictionaryEntry[myCol2.Count];
            myCol2.CopyTo(myArr1, 0);
            foreach (var arr1 in myArr1)
            {
                Console.WriteLine("{0}-->{1}", arr1.Key, arr1.Value);
            }

            Console.WriteLine("Printing the element list using GetEnumerator method-----");
            IEnumerator myEnumerator2 = myCol2.GetEnumerator();
            foreach (DictionaryEntry de in myCol2)
                Console.WriteLine("{0} {1}", de.Key, de.Value);
            Console.WriteLine();
            Console.WriteLine("============HybridDictionary===========");
            HybridDictionary myCol3 = new HybridDictionary();
            myCol3.Add("Braeburn Apples", "1.49");
            myCol3.Add("Fuji Apples", "1.29");
            myCol3.Add("Gala Apples", "1.49");
            myCol3.Add("Golden Delicious Apples", "1.29");
            myCol3.Add("Granny Smith Apples", "0.89");
            myCol3.Add("Red Delicious Apples", "0.99");
            myCol3.Add("Plantain Bananas", "1.49");
            myCol3.Add("Yellow Bananas", "0.79");
            
            foreach (DictionaryEntry de in myCol3)
                Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
            Console.WriteLine();

            Console.WriteLine("Number of elements in myDict are :{0} ", myCol3.Count);
            Console.WriteLine("After Remove=======");
            myCol3.Remove("Gala Apples");
            foreach (DictionaryEntry de in myCol3)
                Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
        }
    }
}