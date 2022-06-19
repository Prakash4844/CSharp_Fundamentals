using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear(); //Clear Console
			Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "Classes Tutorial")); //Prints in the middle on console
			
			/*
			An object is created from a class. We have already created the class named Car, so now we can use this to create objects.

			MyCar is an object. The MyCar has attributes/Member/DataMember, such as Make, Model, color and Year, 
			And It have some Method/Function/Member Function such as CarValue().


			*/
			Car MyCar = new Car(); 
			MyCar.Color = "Red/white"; //Setting Properties value
			MyCar.Make = "Ford";
			MyCar.Model = "Mustang";
			MyCar.Year = 2021;

			Console.WriteLine($"Car = {MyCar.Make} {MyCar.Model} {MyCar.Year}, Color = {MyCar.Color}");//Getting Properties value

			// Decimal CarPrice = CarValue(MyCar);
			// Console.WriteLine("{0:C}", CarPrice);

			Console.WriteLine("{0:C}", MyCar.CarValue());

		}


		// private static decimal CarValue(Car car)
		// {
		//     Decimal MyValue = 100.00M;
		//     return MyValue;
		// }
	}

	//Classes are the user defined data types that represent the state and behaviour of an object. 
	//State represents the properties and behaviour is the action that objects can perform.

	//A Class is like an object constructor, or a "blueprint" for creating objects.
	class Car
	{
		//variables inside a class are called fields, and that you can access them by creating an object of the class, and by using the dot syntax (.).

		public string? Make { get; set; }
		/*
		 *Property in C# is a member of a class that provides a flexible mechanism for classes to expose private fields. 
		 *Internally, C# properties are special methods called accessors. A C# property have two accessors, 
		 *get property accessor and set property accessor. A get accessor returns a property value, and a set accessor assigns a new value.
		*/
		public string? Model { get; set; }
		/*
		* It uses pre-defined methods which are “get” and “set” methods which help to access and modify the properties.

		* Accessors: The block of “set” and “get” is known as “Accessors”. It is very essential to restrict the accessibility of property. 
		* There are two type of accessors i.e. get accessors and set accessors. 
		*/
		public int Year { get; set; }   
		public string? Color { get; set; }

		//Methods are used to perform certain actions, Methods normally belongs to a class, and they define how an object of a class behaves.
		//Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. 
		//And remember that we use the name of the method followed by two parantheses () 
		public decimal CarValue()
		{
			Decimal MyValue = 100.00M; //Here M means it's a decimal literal
			/*
			A decimal number is a floating-point value that consists of a sign, 
			a numeric value where each digit in the value ranges from 0 to 9, 
			and a scaling factor that indicates the position of a floating 
			decimal point that separates the integral and fractional parts of the numeric value.
			*/
			return MyValue;
		}
	}

}

