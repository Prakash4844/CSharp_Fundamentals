using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "Date And Time Tutorial")); //Prints in the middle on console

            DateTime myObj = DateTime.Now;

            /* Prints Date and Time in Differet String formats.

            //Console.WriteLine(myObj.ToString());
            //Console.WriteLine(myObj.ToShortDateString());
            //Console.WriteLine(myObj.ToShortTimeString());
            //Console.WriteLine(myObj.ToLongDateString());
            //Console.WriteLine(myObj.ToLongTimeString());

            */

            /* Adds date or Time and Prints Date and Time in String formats.

            Console.WriteLine(myObj.AddDays(5).ToLongDateString());
            Console.WriteLine(myObj.AddHours(5).ToLongTimeString());
            Console.WriteLine(myObj.AddDays(-5).ToLongDateString());
            Console.WriteLine(myObj.AddHours(-5).ToLongTimeString());

            */

            //Console.WriteLine(myObj.Month);

            //Print a given date
            // DateTime myBirthDay = new DateTime(2002,05,18);
            // Console.WriteLine(myBirthDay.ToShortDateString());


            //Parse a string as a date then subtract it to calculate a timespan which can be either In Days, Time, Second.
            DateTime myBirthDay = DateTime.Parse("2002/05/18");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
            Console.WriteLine(myAge.TotalDays);

        }
    }
}

