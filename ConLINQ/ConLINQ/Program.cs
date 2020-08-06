using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFile(path);
            Console.WriteLine("==============================");
            ShowLargeFilewithlinq(path);
        }

        private static void ShowLargeFilewithlinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles() orderby file.Length 
                        select file;
            foreach(var file in query)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
            Console.WriteLine("===============");
            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }

        private static void ShowLargeFile(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fio= dir.GetFiles();
            Array.Sort(fio, new FileInfoCompare());
            
            foreach (var item in fio)
            {
                Console.WriteLine($"{item.Name} : {item.Length}");
            }
        }
    }
    public class FileInfoCompare : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
