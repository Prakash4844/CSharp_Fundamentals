using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You can store multiple variables of the same type in an array data structure. You declare an array by specifying the type of its elements. */

            int[] number = new int[5]; //Declaring an array which can hold 5 element from index[0-4]
            number[0] = 4; //Assigning Value 4 to array[0] array index 0
            number[1] = 8;  //Assigning Value 8 to array[1] array index 1
            number[2] = 12;
            number[3] = 16;
            number[4] = 20;

           // number[5] = 24; //Trying to Assign Value 24 to array[5] but this array can hold only value till array[4] so,
           //Throw Error: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.


            //Console.WriteLine(number[1]);
            //Console.WriteLine(number.Length); //Print the length of array (no. of element, not index)


            //Better way to Define array;

            int[] number = new int[] {4,8,12,16,20,24,28}; //Simpler way to define array: still complicated than C/C++
            string[] nameOfLoves = new string[] {"Dani Danials", "Emily Agnes", "Leah Gotti", "Manique Alexander", "Young Devotion"}; //A string array.

            for (int i = 0; i < nameOfLoves.Length; i++)        
            {
                Console.WriteLine(nameOfLoves[i]);
            }

            
        }
    }
}

