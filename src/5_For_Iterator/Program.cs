using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_iterators
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)//; seperate each statemnent

            //Here int i = 0 means we are Declaring and intializing a variable i which have a value 0
            //after that we have i<10 which means this loop will iterate till i is less than that of value 10.
            //after each iterartion the value of i is incremented by i++, here ++ is increment operator which increase the value of variable by 1
            //After each time condition is checked the block of code below is executed. 
            {
                Console.WriteLine(i); //print current value of i which get incremented by 1 in each iteration.

                if (i == 5) //check if value of i is 5, which is true in 6th iteration 
                {
                    Console.WriteLine("Five is found");
                    break; //once we found 5 This "break" statement will get executed which will break the loop and loop will terminated executing 
                    /*
                    the break statement is used to terminate a loop(for, if, while, etc.) or a switch statement on a certain condition. 
                    And after terminating the controls will pass to the statements that present after the break statement,
                    if available. If the break statement exists in the nested loop, then it will terminate only those loops which contain the break statements. 
                    */ 
                }
            }
        }
    }
}