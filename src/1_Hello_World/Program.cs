using System;
//The using System line means that you are using the System library in your project. 
//Which gives you some useful classes and functions like Console class or the WriteLine function/method. 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld //Namespace is a way to organize your code it contains classes
{
    //Namespaces are used in C# to organize and provide a level of separation of codes. 
    //They can be considered as a container which consists of other namespaces, classes, etc.

    //A namespace can have following types as its members:
    //1.Namespaces (Nested Namespace)
    //2.Classes
    //3.Interfaces
    //4.Structures
    //5.Delegates


    class Program
    {

        //When you define a class, you define a blueprint for a data type. This does not actually define any data. 
        //but it does define what the class name means. 
        //That is, what an object of the class consists of and what operations can be performed on that object. 
        //Objects are instances of a class. The methods and variables that constitute a class are called members of the class.

        static void Main(string[] args)
        //C# applications have an entry point called Main Method. 
        //It is the first method which gets invoked whenever an application started and it is present in every C# executable file.

        //static: It means Main Method can be called without an object.
        //void: The Main method doesn’t return anything.
        //Main(): It is the configured name of the Main method.
        //String []args: For accepting the zero-indexed command line arguments. 
        //args is the user-defined name. So you can change it by a valid identifier. 
        //[] must come before the args otherwise compiler will give errors.
        {
           Console.WriteLine("This is C#"); //Here we are making a call to dotnet class library which is supplied by Microsoft.
           //Here we are using Console class that has a member method WriteLine which takes an argument.
           //Here we have used a "." to access WriteLine in Console class, "." is called a member accesser
           //() after WriteLine indicates it is a method and ";" means it is to be called and executed. 
           //inside () we pass the argument.
        } 
    }
    
}

