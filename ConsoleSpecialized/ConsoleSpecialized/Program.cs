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
            String[] myArr = new String[] { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            StringCollection myCol = new StringCollection();
            myCol.AddRange(myArr);
            Console.WriteLine("============StringCollection===========");
            StringEnumerator myEnumerator = myCol.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.WriteLine("{0}", myEnumerator.Current);
            Console.WriteLine();


            StringDictionary myCol1 = new StringDictionary();
            myCol1.Add("red", "rojo");
            myCol1.Add("green", "verde");
            myCol1.Add("blue", "azul");
            Console.WriteLine("============StringDictionary===========");
            IEnumerator myEnumerator1 = myCol1.GetEnumerator();
            foreach (DictionaryEntry de in myCol1)
                Console.WriteLine("{0} {1}", de.Key, de.Value);
            Console.WriteLine();

            ListDictionary myCol2 = new ListDictionary();
            myCol2.Add("Braeburn Apples", "1.49");
            myCol2.Add("Fuji Apples", "1.29");
            myCol2.Add("Gala Apples", "1.49");
            myCol2.Add("Golden Delicious Apples", "1.29");
            myCol2.Add("Granny Smith Apples", "0.89");
            myCol2.Add("Red Delicious Apples", "0.99");

            DictionaryEntry[] myArr1 = new DictionaryEntry[myCol2.Count];
            myCol2.CopyTo(myArr1, 0);
            Console.WriteLine("============ListDictionary===========");
            IEnumerator myEnumerator2 = myCol2.GetEnumerator();
            foreach (DictionaryEntry de in myCol2)
                Console.WriteLine("{0} {1}", de.Key, de.Value);
            Console.WriteLine();

            HybridDictionary myCol3 = new HybridDictionary();
            myCol3.Add("Braeburn Apples", "1.49");
            myCol3.Add("Fuji Apples", "1.29");
            myCol3.Add("Gala Apples", "1.49");
            myCol3.Add("Golden Delicious Apples", "1.29");
            myCol3.Add("Granny Smith Apples", "0.89");
            myCol3.Add("Red Delicious Apples", "0.99");
            myCol3.Add("Plantain Bananas", "1.49");
            myCol3.Add("Yellow Bananas", "0.79");
            Console.WriteLine("============HashDictionary===========");
            foreach (DictionaryEntry de in myCol3)
                Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
            Console.WriteLine();


        }
    }
}