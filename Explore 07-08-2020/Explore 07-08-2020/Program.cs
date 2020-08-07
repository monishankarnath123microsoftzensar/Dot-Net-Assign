using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Explore_07_08_2020
{
    class Program
    {
        public static void Main()
        {
            string path = @"E:\temp\MyTest.txt";

            
            if (!File.Exists(path))
            {
               
                string createText = "Hello and Welcome";
                File.WriteAllText(path, createText);
            }

            
            string appendText = "This is extra text";
            File.AppendAllText(path, appendText);

            File.Copy(@"E:\temp\MyTest.txt", @"E:\temp\MyTest2.txt");
            string readText = File.ReadAllText(path);

            File.Delete(@"E:\temp\MyTest2.txt");
            Console.WriteLine(readText);
        }
    }
}