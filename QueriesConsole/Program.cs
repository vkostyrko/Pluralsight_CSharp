using Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueriesConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var movies = new List<Movie>()
            //{
            //    new Movie{Title = "Dark Knight",Raiting = 8.9f,Year = 2008 },
            //    new Movie{Title = "Kings Speech",Raiting = 8.0f,Year = 2010 },
            //    new Movie{Title = "Casablanca",Raiting = 8.5f,Year = 1998 },
            //    new Movie{Title = "Star Wars V",Raiting = 8.7f,Year = 1989 }
            //};
            //var query2 = movies.Where(m => m.Year > 2000).OrderByDescending(m => m.Title);
            ////var query = movies.Filter(m => m.Year > 2000);
            //foreach (var movie in query2)
            //{
            //    Console.WriteLine(movie.Title);
            //}
            var numbers = Enumerable.Range(1, 1000000).Where(i => i % 2 == 0)
    .OrderByDescending(i => i);
            foreach (var number in numbers) Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
