using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPartial
{
    class Person1
    {
        public void Display()
        {

        }
    }
    static class DemoClass
    {
        public static int Add(this int x, int y)
        {
            return x + y;
            
        }
        public static string ConCat(this string s, string s1, string s2)
        {
            return s1 + s2;
        }
        public static void ShowPer(this Person1 p)
        {
            Console.WriteLine("Person class extend");
        }
        public static void All(this List<int> li)
        {

        }
    }
    class ExtensionMethod
    {
        static void Main()
        {
            int x = 10;
            Console.WriteLine(x.Add(5));
            string str = "Hi";
            Console.WriteLine(str.ConCat("Ext","Methods"));
            Person1 p = new Person1();
            p.ShowPer();

            string str1 = "This is a string";
            Console.WriteLine(str1.All((a)=> a != 's'));
        }
    }
}
