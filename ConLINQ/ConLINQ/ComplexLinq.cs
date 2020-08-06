using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLINQ
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T,bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
    class Movie
    {
        public string Title
        {
            get; set;
        }
        public float Rating
        {
            get; set;
        }
        public int year
        {
            get; set;
        }
        
    }
    class ComplexLinq
    {
        static void Main()
        {
            var movies = new List<Movie>
            {
                new Movie {Title = "Super Delux", Rating = 4.2f, year=2019 },
                new Movie {Title = "Special 26", Rating = 4.8f, year=2014 },
                new Movie {Title = "Kurban", Rating = 4.0f, year=2010 },
                new Movie {Title = "3 idiot", Rating = 5.0f, year=2010 }
            };
            //var query = movies.Where(m => m.year > 2010);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Title} and {item.year}");
            //}

            //Custom Filter Method
            Console.WriteLine("==============GroupBy query==================");
            var groupb = from movie in movies
                         group movie by movie.year into newmovie
                         
                         select newmovie;
            
            foreach (var item in groupb)
            {
                Console.WriteLine(item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine(student.Title);
                }

            }
            Console.WriteLine("==============GroupBy Method==================");
            var groupmethod = movies.GroupBy(mov => mov.year).Select(mov => mov);
            foreach (var item in groupmethod)
            {
                Console.WriteLine(item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine(student.Title);
                }

            }

            //var query1 = movies.Filter(m=>m.Title.StartsWith("S"));
            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item.Title);
            //}
        }
    }
}
