using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                An exception is a problem that arises during the execution of a program. A C# exception is a response 
                to an exceptional circumstance that arises while a program is running, such as an attempt to divide 
                by zero.

                Exceptions provide a way to transfer control from one part of a program to another. 
                C# exception handling is built upon four keywords: try, catch, finally, and throw.

                1. try − A try block identifies a block of code for which particular exceptions is activated. 
                    It is followed by one or more catch blocks.

                2. catch − A program catches an exception with an exception handler at the place in a program where 
                    you want to handle the problem. The catch keyword indicates the catching of an exception.

                3. finally − The finally block is used to execute a given set of statements, whether an exception is 
                    thrown or not thrown. For example, if you open a file, it must be closed whether an exception
                    is raised or not.

                4. throw − A program throws an exception when a problem shows up. This is done using a throw keyword.             
             
             */

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Exception Handling Tutorial")); //write in centre of console.

            //Console.WriteLine(File.ReadAllText("D:\\Users\\Zaphkil!\\Desktop\\Plan to watch Movies and Series.txt")); 

            //string content = File.ReadAllText(@"D:\Users\Zaphkil!\Documents\VS Code\C#\NEWER\CSharp_Fundamentals\src\19_Exception_Handling/Example.txt");
            //both above statement Works.
            //

            //Lets Create an Exception:
            try
            {
                string content = File.ReadAllText(@"D:\Users\Zaphkil!\Documents\VS Code\C#\NEWER\CSharp_Fundamentals\src\19_Exception_Handling/Exampl.txt");
                Console.WriteLine(content);
            }
            catch (DirectoryNotFoundException Ex) 
            {
                Console.WriteLine("The Was a problem.");
               
                Console.WriteLine(Ex.Message);
                Console.WriteLine("Make Sure the 'File Path' is correct.");
            }
            catch (FileNotFoundException Ex)
            {
                Console.WriteLine("The Was a problem.");
               
                Console.WriteLine(Ex.Message);
                Console.WriteLine("Make sure the 'File Name' is correct.");
            }
            catch (Exception ex)
            {

                Console.WriteLine("The Was a problem.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Finalizing Code will always run, Closing Connections, Setting Obj to Null Etc.
                Console.WriteLine("Closing Application...");
            }

        }
    }
}