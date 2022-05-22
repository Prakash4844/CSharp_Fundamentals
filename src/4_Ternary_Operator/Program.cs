
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "If Else Tutorial")); //write in centre of console.

            Console.WriteLine("A Game"); 

            Console.WriteLine("Choose a Door: A, B And C:");
            string? userValue = Console.ReadLine(); //stores the input by user in userValue string which is a (nullable reference type)

            //Here we are using ternary operator(Nested) instead of an if else clause 
            string? message =   userValue == "A"? "won a Car." : //This means if UserValue is "A" the get "You get a Car." in message variable otherwise move to next ternary operator.  
                                
                                userValue == "B"? "won a MotorBike." : //This means if UserValue is "B" the get "You get a MotorBike." in message variable otherwise move to next ternary operator.  
                                
                                userValue == "C"? "won a Cycle. " : "didn't Win. But you get a participation Gift.";
                                //This means if UserValue is "C" the get "You get a Cycle." in message variable else get "You Didn't Win. But you get a participation Gift." in message variable
            
            //Console.Write("You won,")
            //Console.Write(message); //This will print whatever string is in message variable. 
            //Console.Write(".")
            //Here instaed of multiple write we can use formatted strings.
            //=========================================================================================

            //Above we were just printing message instead let me show you two method which can be used to print formatted strings 
            
            // 1. Composite formatting
            /*
            The .NET composite formatting feature takes a list of objects and a composite format string as input. 
            A composite format string consists of fixed text intermixed with indexed placeholders, called format items, 
            that correspond to the objects in the list. 
            The formatting operation yields a result string that consists of the original fixed text intermixed with the string representation of the objects in the list.
            */

            //Console.WriteLine("You entered {0}, so you {1}" , userValue, message);

            /*
            The fixed text is "You entered " and ", so you won ". 
            The format items are "{0}", whose index is 0, which corresponds to the userValue, 
            and "{1}", whose index is 1, which corresponds to message.
            */
            //=========================================================================================

            // 2. $ - string interpolation (Interpolation is the process of estimating unknown values that fall between known values.)
            /*
            The $ special character identifies a string literal as an interpolated string. 
            An interpolated string is a string literal that might contain interpolation expressions. 
            When an interpolated string is resolved to a result string, 
            items with interpolation expressions are replaced by the string representations of the expression results. 
            This feature is available starting with C# 6.
            */

            Console.WriteLine($"You entered {userValue}, so you {message}");

            //To identify a string literal as an interpolated string, prepend it with the $ symbol. 
            //You can't have any white space between the $ and the " that starts a string literal.

            //NOTE: string interpolation is turned into string.Format() at compile-time.
        }
    }
}