using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace methods
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Methods Tutorial")); //prints in middle of console.

            Console.WriteLine("Enter Your First Name: ");
            string? firstName = Console.ReadLine(); //takes input which can be (?)nullable reference type

            Console.WriteLine("Enter Your Last Name: ");
            string? lastName = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            string? city = Console.ReadLine();

            DisplayResults(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.WriteLine();
            Console.Write("Result: ");
            DisplayResults(ReverseString(firstName));
            DisplayResults(ReverseString(lastName));
            DisplayResults(ReverseString(city));
            
        }

        private static string ReverseString(string? message) //Method apart from Main Method

        /*

        Here The private keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.
        private means The code is only accessible within the same class.
        
        static - ignore for now

        string keyword here means this method return a string value.

        ReverseString is the name of method which will be used to invoke(call) it.

        () in these parenthesis we can define which parameter will this function accept.

        string? message means that this function would require a string parameter which can be (?)null. 



        */
        {
            char[] messageArray = message!.ToCharArray(); //here we are converting our string parameter to a character array. using helper function TocharArray.

            Array.Reverse(messageArray); //Here we are using Helper function Array.Reverse() to reverse messageArray which we created in last statement.

            return string.Concat(messageArray); //here we are using Helper funtion string.Concat to concate all the char array to a string.
            
        }

        private static void DisplayResults(string? reversedFirstName, string? reversedLastName, string? reversedCity)
        /*
        //Method apart from Main Method and ReverseString Method

        

        Here The private keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.
        private means The code is only accessible within the same class.
        
        void keyword here means this method wouldn't return any value.

        DisplayResult is the name of method which will be used to invoke(call) it.

        () in these parenthesis we can define which parameter will this function accept.

        string? {parameter name} means that this function would require a string parameter which can be (?)null. 

        */
        {
            
            Console.Write(string.Format("Result: {0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
            //prints the parameters

        }

        private static void DisplayResults(string? messaege)
         /*
        //overloaded DiplayResult Method apart from Main Method and ReverseString Method

        Here The private keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.
        private means The code is only accessible within the same class.
        
        void keyword here means this method wouldn't return any value.

        DisplayResult is the name of method which will be used to invoke(call) it.

        () in these parenthesis we can define which parameter will this function accept.

        string? {parameter name} means that this function would require a string parameter which can be (?)null. 
        */
        {
            
            Console.Write(messaege + " ");

        }
    }   
}

