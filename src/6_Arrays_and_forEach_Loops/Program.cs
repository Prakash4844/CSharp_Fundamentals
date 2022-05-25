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
            int[] number = new int[] {4,8,12,16,20,24,28}; //Simpler way to define array: still harder then C/C++

            string[] nameOfLoves = new string[] {"Dani Danials", "Emily Agnes", "Leah Gotti", "Manique Alexander", "Young Devotion"}; //A string array."};

            /*
            C# provides an easy to use and more readable alternative to for loop, 
            the foreach loop when working with arrays and collections to iterate through the items of arrays/collections. 
            The foreach loop iterates through each item, hence called foreach loop.
            */ 
            foreach (string name in nameOfLoves)  //We are iterating through each name in our string array nameOfLoves.
            {
                Console.WriteLine(name);
            }

            string saying = "If people refuse to accept you, I'll just accept you even more.";
            char[] sayingArray = saying.ToCharArray();
            Array.Reverse(sayingArray);


            Console.Write("Backward saying: ");
            foreach (char say in sayingArray)
            {
                Console.Write(say);
            }
        }
    }
}

