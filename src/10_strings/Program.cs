using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "Strings Tutorial")); //Prints in the middle on console
            
            // NOTE: Comment Out parts of code to test them out.

            //string myStr = "Using \"Double Quotes\" inside a string.";
            /*  These are basically the special characters or escape characters. 
                The backslash character (\) in a regular expression.
                it indicates that the character that follows it either is a special character or should be interpreted literally.
            */
            //=======================================================================

            //string myStr = "Enter a new line by\nescape character."; // (\n) means new line chracter

            //=======================================================================

            //string myStr = "Use a \\ character as it is."; // (\\) is interpreted as \ itself

            //=======================================================================

            //string myStr = @"Use a \ character as it is.";
            /*
                @ marks the string as a verbatim(exactly as it was written) string literal,
                        anything in the string that would normally be interpreted as an escape sequence is ignored.

                So "C:\\Users\\Rich" is the same as @"C:\Users\Rich"

                There is one exception: an escape sequence is needed for the double quote. To escape a double quote, 
                        you need to put two double quotes in a row. For instance, @"""" evaluates to ".
            */

            //=======================================================================
            //String.Format can use list of place holder in any order

            // string myStr = string.Format("{0} = {1}" , "A", "B");
            // string myStr = string.Format("{0} = {0}" , "A", "B");
            // string myStr = string.Format("{1} = {1}" , "A", "B");
            // string myStr = string.Format("{1} = {0}" , "A", "B");

            // string myStr = string.Format("Money = {0:C}" , 420); //Displays 420 as currency{0:C} that is used by your system.
            // string myStr = string.Format("Number = {0:N}" , 874617468475); //displays 874617468475 as Number{0:N} with proper format.
            // string myStr = string.Format("Percentage = {0:P}" , .420);  //displays .420 as Percentage{0:P}

            // string myStr = string.Format("Percentage = {0:### ###-####}" , 6544736431);  //displays 6544736431 as Custom Formatted Strings using # symbol
            
            //string myStr = " Black and blue I crawl along The wreckage of what now is gone  ";

            // myStr = myStr.Substring(7,25); //Print a substring from string, starting at 7 and next 25 character.
            // myStr = myStr.ToUpper(); //Make string Uppercase
            // myStr = myStr.Remove(7, 27); //Delete a substring from string, starting at 7 and next 27 character.
            // myStr = myStr.Replace(" ", "--"); //Replace all the " " with "--"
            // myStr = string.Format("Length Before {0} and Length After Trim {1}", myStr.Length, myStr.Trim().Length); 
            //                     //Print the length of string before and after trimming(Remove trailing spaces)

            //======================================================================= 

            // string myStr = "";

            // for (int i = 0; i <= 100; i++)
            // {
            //     myStr += "--" + i.ToString();
            // }

            //NOTE: String is immutable(Can't be changed) Datatype so here whenever we try to add a new value to string then a new string is created 
                    // and everything is copied from old string along with new value in it. this happens 100 times above THIS IS VERY UNOPTIMIZED.
                    //Below is a better method.

            //======================================================================= 
            //We are using a string builder class.
            
            StringBuilder myStr = new StringBuilder();

            for (int i = 0; i <= 100; i++)
            {
                myStr.Append("--");
                myStr.Append(i);
            }
            //Here we are working with string much efficiently using string builder class.
            //Try to use string builder class whenever you need to build a string.
            Console.WriteLine(myStr); 
            
        }
    }
}
