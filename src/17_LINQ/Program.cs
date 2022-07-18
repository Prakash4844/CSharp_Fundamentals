using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace UnderstandingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Working With LINQ")); //Prints in the middle on console

            /*
             Language-Integrated Query (LINQ) is a powerful set of technologies based on the integration of query capabilities directly into 
                the C# language. LINQ Queries are the first-class language construct in C# .NET, just like classes, methods, events. 
                The LINQ provides a consistent query experience to query objects (LINQ to Objects), relational databases (LINQ to SQL), 
                and XML (LINQ to XML).

                LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET to retrieve data from different sources and formats. 
                It is integrated in C# or VB, thereby eliminating the mismatch between programming languages and databases, 
                as well as providing a single querying interface for different types of data sources.

                LINQ extends the language by the addition of query expressions, which are similar to SQL statements. 
                LINQ query expressions can be used to conveniently extract and process data from arrays, enumerable classes, XML documents, 
                relational databases, and third-party data sources.

                Query expressions can be used to query and to transform data from any LINQ-enabled data source. Query expressions have 
                deferred execution. They are not executed until we iterate over the query variable, for example, in a foreach statement.
             */

            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "C1", Make = "BMW", Model = "GTO Judge", StickerPrice = 55000, Year = 1969},
                new Car() { VIN = "C2", Make = "Mustang", Model = "GT Shellby", StickerPrice = 65000, Year = 1979},
                new Car() { VIN = "C3", Make = "BMW", Model = "Lumina SS", StickerPrice = 75000, Year = 1989},
                new Car() { VIN = "C4", Make = "Porsche", Model = "914 GT4", StickerPrice = 85000, Year = 1999},
                new Car() { VIN = "C5", Make = "BMW", Model = "R8", StickerPrice = 95000, Year = 2009}
            };

            /*
             * LINQ queries can be written in the query syntax or the method syntax.
             */

            //LINQ QUERY Syntex

            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2009
                       select car;
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            //LINQ Method Syntex

            /*
             C# allows variables to be declared as explicit type or implicit type. Implicitly typed local variables are strongly typed 
            just as if you had declared the type yourself, but the compiler determines the type at run time depending on the Initial value 
            stored in them. The C# var keyword is used to declare implicit type variables in C#. 
             */

            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2009); 

            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW"); //Chaning methods

            //Console.WriteLine(firstBMW.VIN);

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 1990));
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 1950));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.Model == "R8"));
            //Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));
            Console.WriteLine(myCars.GetType());

            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2009);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2009
                       select new { car.Make, car.Model };//Here we are doing projection
            /*
             Projection refers to the operation of transforming an object into a new form that often consists only of those properties 
                that will be subsequently used. By using projection, you can construct a new type that is built from each object. 
             */

            Console.WriteLine(newCars.GetType()); 

            /* 
             * Here inside the parenthesis is a what is called a Lambda Expression
                 Consider it as a mini method: It says in MyCars List<> on instance only return instance that satisfies given conditions
                 and store it in our subcollection bmws or orderedCars
             */

            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);
            //}

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int StickerPrice { get; set; }
        public int Year { get; set; }
    }
}
