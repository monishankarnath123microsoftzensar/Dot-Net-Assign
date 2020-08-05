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
            List<Person> LPerson = new List<Person>();
            Person per1 = new Person(21, "Moni", "Nath", "Kolkata");
            Person per2 = new Person(32, "Moni", "Nath", "Chennai");
            Person per3 = new Person(51, "Dustu", "Nath", "goriwali");
            Person per4 = new Person(27, "David", "Bhusan", "Pune");
            Person per5 = new Person(29, "Shankar", "Nath", "Kolkata");
            
            LPerson.Add(per1);
            LPerson.Add(per2);
            LPerson.Add(per3);
            LPerson.Add(per4);
            LPerson.Add(per5);

            //    var listper = new List<Person>
            //    {
            //        new Person(21, "Moni", "Nath", "Kolkata"),
            //        new Person(32, "Moni", "Nath", "Chennai"),
            //        new Person(51, "Moni", "Nath", "goriwali"),
            //        new Person(27, "David", "Bhusan", "Pune"),
            //        new Person(29, "Shankar", "Nath", "Kolkata"),
            //};
            foreach (Person p in LPerson)
            {
                p.DisplayPerson();
            }
        }
    }
}
