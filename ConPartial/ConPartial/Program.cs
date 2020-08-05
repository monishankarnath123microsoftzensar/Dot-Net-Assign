using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPartial
{
    class Person
    {

    }
    partial class Employee:Person
    {
        int eid;
        double sal;
        public Employee()
        {
                
        }
        partial void Display()
        {
            Console.WriteLine("display partial method");
        }
    }
    partial class Employee
    {

    }
    partial class Program
    {
        static partial void Result();
        static void Main(string[] args)
        {
            Result();
        }
    }
    partial class Program
    {
        static partial void Result()
        {
            Console.WriteLine("Display +++++++++++++++");
        }
    }
}