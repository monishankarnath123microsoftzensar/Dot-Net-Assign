using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_08_2020
{
    class Person
    {
        int age;
        string fName;
        string lName;
        string city;
        public Person()
        {

        }
        public Person(int _age, string _fname, string _lname, string _city)
        {
            age = _age;
            fName = _fname;
            lName = _lname;
            city = _city;
        }
        public void DisplayPerson()
        {
            Console.WriteLine("Name: {0} {1} Age: {2} City: {3}",fName,lName,age,city);
        }
    }
        class Program
        {
            static void Main(string[] args)
        {
            List<string,string> LPerson = new List<Person>();
            LPerson.
        }
    }
}
