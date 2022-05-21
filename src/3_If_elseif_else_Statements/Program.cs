using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "If Else Tutorial")); //write in centre of console.

            Console.WriteLine("A Game");

            Console.WriteLine("Choose a Door: A, B And C:");
            string? userValue = Console.ReadLine();


            if (userValue == "A") //If statement are called decision statements it will execute a code inside a if statement only if a condition is satisfied.
                                    //otherwise the code inside if statement is ignored
            {
                string message = "You Get a Car!";
                Console.WriteLine(message);

            }
        }
    }
}