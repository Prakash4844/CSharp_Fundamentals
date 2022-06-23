using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "More about Classes (Constructors)")); //Prints in the middle on console

            Car? myCar = new Car(); //Invokes te Car() Construtor which have no parameters

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Colour}");//Printing properties by myCar Instance

            Car? mySecondCar = new Car("Ford", "Mustang", 2022, "Yellow/White");
            //Invokes te Overloaded Car() Construtor which have 4 parameters

            Console.WriteLine($"{mySecondCar.Make} {mySecondCar.Model} {mySecondCar.Year} {mySecondCar.Colour}");//Printing properties by mySecondCar Instance

            Car.StatMethod(); //Static Method Called without calling an instance
            
        }

        
    }

    class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }   
        public string? Colour { get; set; }

        /// <summary>
        /// C#, constructor is a special method which is invoked automatically at the time of object creation. 
        /// It is used to initialize the data members of new object generally. The constructor in C# has the same name as class or struct.
        /// A constructor which has parameters is called parameterized constructor. It is used to provide different values to distinct objects.

        /// There can be two types of constructors in C#.

        /// 1. Default constructor (Supplied Automatically if not defined)
        ///             A constructor which has no argument is known as default constructor. It is invoked at the time of creating object.
        /// 
        /// 2. Parameterized constructor (User Created)
        ///             A constructor which has parameters is called parameterized constructor. It is used to provide different values to distinct objects.
        /// </summary>
        public Car() //No parameter
        {
            this.Make = "Ford";
        }

        public Car(string make, string model, int year, string colour) //Constructor Overloaded with parameters
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }

        /*
        In C#, static means something which cannot be instantiated. 
        You cannot create an object of a static class and cannot access static members using an object.

        C# classes, variables, methods, properties, operators, events, and constructors can be defined as static using the static modifier keyword.
        */

        public static void StatMethod()
        {
            Console.WriteLine("The static Method StatMethod was Called.");
        }


        /*
        Static Method Vs Non Static Method

                    Static Method	                                            Non Static Method/Instance Method
        1. Static method is defined with the static keyword.	    1. Non Static Method is defined without static keyword.
        2. Static method is called by its class name	            2. Non Static Method is called by making the object of a class.
        3. We can’t use this keyword inside the Static Method	    3. We can use this keyword inside Non Static Method
        4. Static Method uses the memory of Class	                4. Non Static Method uses a memory of an object

        */

    }
}

