using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmnumAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Enumerations and Switch Statments")); //Prints in the middle on console

            /*
             * An enumeration is a set of named integer constants. An enumerated type is declared using the enum keyword.

                C# enumerations are value data type. In other words, enumeration contains its own values and cannot inherit 
                or cannot pass inheritance.

            Enumeration (or enum) is a value data type in C#. It is mainly used to assign the names or string values 
            to integral constants, that make a program easy to read and maintain. 
             */

            //Using Collection Intializer Syntex
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted },
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted },
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress },
                new Todo { Description = "Task 10", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted },
                new Todo { Description = "Task 12", EstimatedHours = 10, Status = Status.Completed },
                new Todo { Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 14", EstimatedHours = 6, Status = Status.Completed },
            };

            Console.ForegroundColor = ConsoleColor.Red;

            PrintAssesment(todos);

        }

        private static void PrintAssesment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                /*
                 * In C#, Switch statement is a multiway branch statement. It provides an efficient way to transfer the execution to 
                 * different parts of a code based on the value of the expression. The switch expression is of integer type such as 
                 * int, char, byte, or short, or of an enumeration type, or of string type. The expression is checked for different 
                 * cases and the one match is executed.
                 */

                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set;}
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
