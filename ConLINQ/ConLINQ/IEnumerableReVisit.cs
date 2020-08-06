﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLINQ
{
    class IEnumerableReVisit
    {
        static void Main()
            {

                IEnumerable<Employee> developers = new Employee[]
                 {
                new Employee{Id=1,Name="Scott"},
                new Employee{Id=2,Name="Alex"}



                 };



                IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id=3,Name="Dipanjan"},
                new Employee{Id=4,Name="Shravni"}
            };
                Console.WriteLine("Developers List");
                //foreach (var person in developers)
                //{
                //    Console.WriteLine(person.Name);
                //}



                IEnumerator<Employee> enumerator = developers.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current.Name);
                }
                Console.WriteLine("Sales List");
                foreach (var person in sales)
                {
                    Console.WriteLine(person.Name);
                }



                var query1 = developers.Where(e => e.Name.Length == 5)
                    .OrderBy(e => e.Name)
                    .Select(e => e);



                var query2 = from dev in developers
                             where dev.Name.Length == 5
                             orderby dev.Name descending
                             select dev;



                Console.Read();
            }
    }
}
