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
            string? userValue = Console.ReadLine(); //stores the input by user in userValue string which is a (nullable reference type)

            string? message = ""; //Empty string


            if (userValue == "A") //If statement are called decision statements it will execute a code inside a if statement only if a condition is satisfied.
            //otherwise the code inside if statement is ignored, if an if statement's condition is satisfied then whole if elseif else clause after it will be skipped over.
            //if condition is not satisfied next else if condition will be checked
            {
                message = "You Get a Car!"; //assigning a string in string variable message
            }
            else if(userValue == "B")//else If statement are called decision statements it will execute a code inside a if statement only if a condition is satisfied.
            //otherwise the code inside if statement is ignored, if an if statement's condition is satisfied then whole if elseif else clause after it will be skipped over.
            //if condition is not satisfied next else if condition will be checked
            {
                message = "You won a MotorBike!";
            }

            else if(userValue == "C")//else If statement are called decision statements it will execute a code inside a if statement only if a condition is satisfied.
            //otherwise the code inside if statement is ignored, if an if statement's condition is satisfied then whole if elseif else clause after it will be skipped over.
            //if condition is not satisfied next else if condition will be checked
            {
                message = "You won a Cycle!";
            }

            else //If all the above conition fails then this else clause will be executed irrespect of input.
            {
                message = "You didn't win. ";
                message += "but, you get a participating gift!"; //here we are concatenating a string after the value of message using concatanation assignment operator += 
            }

            Console.WriteLine(message); //This will print whatever string is in message variable. 
        }
    }
}