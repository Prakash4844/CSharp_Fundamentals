using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Data Type And Variable Tutorial")); //write in centre of console.
            
            int x; //Declared Variable of Type Integer(it is a whole number within a limit which is -2,147,483,648 to 2,147,483,647) Named 'x'.
            int y; //Declared Variable of Type Integer(it is a whole number within a limit which is -2,147,483,648 to 2,147,483,647) Named 'y'.

            x = 7; //assigning value 7 to x (assigning a value to a variable is known as initialization).
            y = x + 3; //adding 3 to the value of x and assigning it to y.

            Console.WriteLine(y);
            */

            Console.WriteLine("What is your Name?"); //Writeline method write a line and moves on to next line.
            Console.Write("Type your First Name: "); //Write method write a line and remains on the same line.

            string? myFirstName; //Declared Variable of Type String(it can hold a string(collection) of characters) Named "myFirstName".
            myFirstName = Console.ReadLine(); //Taking User input in Variable "myFirstName" and moving to next line.
            
            // string? myFirstName; //can't redefine same varaible twice

            Console.Write("Type your Last Name: ");
            
            string? myLastName = Console.ReadLine(); //Declared Variable of Type String(it can hold a string(collection) of characters) Named "myLastName".
            //Taking User input in Variable "myLastName" and moving to next line.

            Console.WriteLine("Hello, "+ myFirstName +" "+ myLastName + "."); //Here we are concatenating the 2 string variables to print full name.

            /*
            Tip for NOTE: If you are totally new and don't understand this you can ignore it now, and come back to it later on.

            NOTE: string can hold a string(collection) of characters. 
            but "?" after the string datatype as written in code "string?" means Adding the '?' makes that value type nullable. 
            Meaning it can accept nothing to be stored inside it and not complain. Without the '?' it always has to take in some kind of input. 
            You can do this with other data types as well.

            For Knowing more about it refer to https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
            */


        }
    }
}