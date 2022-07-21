using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Timers;

namespace TimerEx
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Events are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as 
                system generated notifications. Applications need to respond to events when they occur. 
                For example, interrupts. Events are used for inter-process communication.

            Events are user actions such as key press, clicks, mouse movements, etc., 
            or some occurrence such as system generated notifications. 
            Applications need to respond to events when they occur. For example, interrupts. 
            Events are used for inter-process communication.
             */
            Console.Clear();
            Console.WriteLine(string.Format("{0, " + Console.WindowWidth / 2 + "}", "Event Tutorial"));//Print in middle of console.

            System.Timers.Timer MyTimer = new System.Timers.Timer(2000);

            MyTimer.Elapsed += MyTimer_Elapsed;
            MyTimer.Elapsed += MyTimer_Elapsed1;

            MyTimer.Start();

            Console.WriteLine("Press Enter to terminate Red Event");
            Console.ReadLine();

            MyTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object? sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0:HH:mm:ss.fff}", e.SignalTime);

        }
    }
}
