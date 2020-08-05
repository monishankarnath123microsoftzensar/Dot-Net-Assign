using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPartial
{
    class Demo
    {
        static string name;
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        static string[] cities = new string[5];
        public string this[int i]
        {
            get { return cities[i]; }
            set { cities[i] = value; }
        }
    }
    class IndexerDemo
    {
        static void Main()
        {
            Demo d = new Demo();
            d[0] = "Pune";
            d[1] = "Kolkata";
            d[2] = "Nashik";
            d[3] = "Kolapur";
            d[4] = "Hydrabad";
            for(int i =0; i< 5; i++)
            {
                Console.WriteLine(d[i]);
            }
            ArrayList arr = new ArrayList(new Object[10]);//beacuse public virtual object this[int index]
            arr[0] = "hello";
            arr[1] = 23;
            arr[2] = 'c';
            arr[3] = true;
            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
            Hashtable ht = new Hashtable();//beacuse public virtual object this[object key]
            ht[1] = "one";
            ht["two"] = "two";
            ht[3] = 4578;
            foreach(DictionaryEntry a in ht)
            {
                Console.WriteLine(a.Key +" " +a.Value);
            }
        }
    }
}
