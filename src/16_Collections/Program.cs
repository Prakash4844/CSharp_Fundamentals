using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Collections")); //Prints in the middle on console

            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Mustang";
            car1.VIN = "2B";

            Car car2 = new Car();
            car2.Make = "Lamborghini";
            car2.Model = "Hurracan";
            car2.VIN = "02";

            Book b1 = new Book();
            b1.Author = "JK";
            b1.ISBN = "0 - 000 - 00000 - 0";
            b1.Title = "Mystic Dragon";

            /*
             * C# Generic & Non-generic Collections
                    C# includes specialized classes that store series of values or objects are called collections.

                    There are two types of collections available in C#: non-generic collections and generic collections.

                    The System.Collections namespace contains the non-generic collection types and System.Collections.Generic namespace 
                    includes generic collection types.

                    In most cases, it is recommended to use the generic collections because they perform faster than non-generic collections 
                    and also minimize exceptions by giving compile-time errors.
             */

            /*
             1. ArrayList:
                It represents ordered collection of an object that can be indexed individually.

                It is basically an alternative to an array. However, unlike array you can add and remove items from a list at a specified 
                position using an index and the array resizes itself automatically. It also allows dynamic memory allocation, adding, 
                searching and sorting items in the list.
             */
            ////ArrayList are Dynamically sized
            ////Can be sorted, Added and remove items

            //ArrayList MyarrayList = new ArrayList();
            //MyarrayList.Add(car1);
            //MyarrayList.Add(car2);
            //MyarrayList.Add(b1);
            ////MyarrayList.Remove(b1); //Added Later

            //foreach (Car car in MyarrayList)
            //{
            //    Console.WriteLine(car.Make);
            //} 
            //  Above Snippet will throw an invalidCastException

            /*C# collection types are designed to store, manage and manipulate similar data more efficiently. Data manipulation includes adding, removing, finding, and inserting data in the collection. Collection types implement the following common functionality: 

            1.Adding and inserting items to a collection
            2.Removing items from a collection
            3.Finding, sorting, searching items
            4.Replacing items
            5.Copy and clone collections and items
            6.Capacity and Count properties to find the capacity of the collection and number of items in the collection

            .NET supports two types of collections, generic collections and non - generic collections.Prior to .NET 2.0
            it was just collections and when generics were added to .NET, generics collections were added as well.

            Generic collections with work generic data type.
            
             Non-generic                          Generic

            ArrayList     ------------->          List

            HashTable     ------------->          Dictionary

            SortedList    ------------->          SortedList  

            Stack         ------------->          Stack

            Queue         ------------->          Queue
             
             */

            /*
             List<T>:	It is a dynamic array that provides functionality similar to that found in the non-generic ArrayList class.

                These collections are type-safe because they are generic means only those items that are type-compatible with the type of 
                the collection can be stored in a generic collection, it eliminates accidental type mismatches. 
             */

            List<Car> MyList = new List<Car>();
            MyList.Add(car1);
            MyList.Add(car2);
            //MyList.Add(b1); //Cannot Convert from Collection.book to Collection.car

            foreach (Car car in MyList)
            {
                Console.WriteLine(car.Make);
            }


            /*
             Dictionary<TKey,TValue>	Represents a collection of key/value pairs that are organized based on the key.
                                        It stores key/value pairs and provides functionality similar to that found in the non-generic Hashtable class.
             */

            Dictionary<string, Car> MyDict = new Dictionary<string, Car>();
            MyDict.Add(car1.VIN, car1);
            MyDict.Add(car2.VIN, car2);

            Console.WriteLine(MyDict["02"].Model);
            Console.WriteLine(MyDict["2B"].Model);

            //Array of String
            string[] Names = { "Prakash", "Kavya" };

            //Object Initializer Syntex
            Car car3 = new Car() { Make = "DC", Model = "Avanti", VIN = "A2" };

            //Collection Initializer Syntex
            List<Car> MyCars = new List<Car>()
            {
                new Car {Make = "Ford", Model = "Mustang", VIN = "2B" },
                new Car {Make = "Lamborghini", Model = "Hurracan", VIN = "02" }
            };
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}