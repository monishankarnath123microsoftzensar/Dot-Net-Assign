using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLINQ
{
    class LinqQuerrie
    {
        static void Main()
        {
            //Linq queries can be written in 2 ways
            //1.Query Syntax starts with from end with select
            string[] cities = { "Kolkata", "Pune", "Loss Angels", "London", "Hydrebad","Ludiana", };
            //IEnumerable<string> filteredCities = from city in cities
            //                                     where city.StartsWith("L") && city.Length < 15
            //                                     orderby city
            //                                     select city;

            //OR

            var filteredCities = from city in cities
                             where city.StartsWith("L") && city.Length < 15
                             orderby city
                             select city;
            var allcities = from city in cities select city;
            
            foreach (var item in filteredCities)
            {
                Console.WriteLine(item);
            }
            //2.Method Syntax
            Console.WriteLine("Method Syntax");
            var methodsyntax = cities.
                Where(c => c.StartsWith("L") && c.Length < 15).
                OrderBy(c => c).
                Select(c => c);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}