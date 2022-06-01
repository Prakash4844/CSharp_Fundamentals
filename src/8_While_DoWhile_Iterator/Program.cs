using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class progarm
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "While Loop Tutorial")); //Prints in the middle on console
            
            bool displayMenu = true; //bool type varible can only be true or false

            while(displayMenu == true) //Runs till displaymenu is true
            {
                displayMenu = MainMenu(); //call main menu method and return a bool value to displayMenu
            }
        }

        private static bool MainMenu() //mainmenu funtion of returnType bool 
        {
            Console.Clear(); //clear console 
            Console.WriteLine("Enter a option."); 
            Console.WriteLine("1. Print Number");
            Console.WriteLine("2. Guess a Number");
            Console.WriteLine("3. Exit");
            string? result = Console.ReadLine(); // take option input in result which can nullable reference type

            Console.WriteLine("Print Numbers!");
            if(result == "1") //if result is 1
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}","Print Numbers!")); 
                Console.Write("Enter a No.:");

                int num = Convert.ToInt32(Console.ReadLine());  //take an input and convert to 32bit int.
                
                int counter = 1;

                while (counter <= num) //prints num till specified num
                {
                    Console.Write(counter);
                    Console.Write("-");
                    counter++; 
                }

                Console.ReadLine();
                return true;
            }
            else if (result == "2") //if result is 2
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}","Guess Numbers!"));

                Random randNumber = new Random(); //instance of a random class (object randnumber)

                int randomNumber = randNumber.Next(11); //generate a random number < 11

                int guesses = 0; 

                bool incorrect = true;

                do
                {
                    Console.WriteLine("Enter your guess: ");
                    int guessedNum = Convert.ToInt32(Console.ReadLine());    //take an input and convert to 32bit int.
                    guesses++;
                    if (guessedNum == randomNumber)
                    {
                        Console.WriteLine($"WAOH!!, You Guessed The corret number, Congratulations \n you took {guesses} guesses.");
                        incorrect = false;
                    }
                    else if (guessedNum < randomNumber)
                    {
                        Console.WriteLine("Your Guess is too small, try a larger no.");
                    }
                    else if (guessedNum > randomNumber)
                    {
                        Console.WriteLine("Your Guess is too large, try a smaller no.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                    
                } while (incorrect == true);

                Console.ReadLine();
                return true;
            }
            else if (result == "3") //if result is 3
            {
                return false; //return false as bool value which will help exit the code.
            }
            else
            {
                Console.WriteLine("Invalid Input, Try again.");
                Console.ReadLine();
                return true;
            }
        }   
    }
}