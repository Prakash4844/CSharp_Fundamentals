using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNamespace
{
    class program
    {

        // A variable scope refers to the availability of variables in certain parts of the code.

        // In C#, when we declare a variable inside a class, the variable can be accessed within the class. 
        // This is known as class level variable scope.

        // Class level variables are known as fields and they are declared outside of methods, constructors, 
        // and blocks of the class.

        //In C#, a variable has three types of scope:

        // 1. Class Level Scope
        // 2. Method Level Scope
        // 3. Block Level Scope

        private static string K = "";
        //// In C#, when we declare a variable inside a class, the variable can be accessed within whole class. 
        // This is known as class level variable scope.

        // Class level variables are known as fields and they are declared outside of methods, constructors, 
        // and blocks of the class.

        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "Scope and Access Modifier")); //Prints in the middle on console

            string j = "";

            // When we declare a variable inside a method (j), the variable cannot be accessed outside of the method. 
            // This is known as method level variable scope.

            for (int i = 1; i <= 10; i++)
            {
                j = i.ToString();
                K = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                // Console.WriteLine(l);

            }

            Console.WriteLine("j can Be accessed in the whole program class, J: "+ j);
            Console.WriteLine("j can Be accessed in the whole program class, K: "+ K);
            HelperMethod();
            
            // Console.WriteLine(i);
            // Here (i) That was used in the above for loop is not accessble because it is out of scope.
            // When we declare a variable inside a block (for loop, while loop, if..else), the variable can only be accessed within the block. 
            // This is known as block level variable scope.

            
        }

        private static void HelperMethod()
        {
            Console.WriteLine("K is accessable in whole class: "+ K);

            Car MyShitCar = new Car();
            MyShitCar.DoSomeShit();
            
        }
    }

    class Car
    {

        // In C#, access modifiers specify the accessibility of types (classes, interfaces, etc) 
        // and type members (fields, methods, etc). 

        //===> Types of Access Modifiers
        
        // In C#, there are 4 basic types of access modifiers.
        // public: When we declare a type or type member public, it can be accessed from anywhere.

        // private: When we declare a type member with the private access modifier, it can only be accessed within the same class or struct.
        
        // protected: When we declare a type member as protected, it can only be accessed from the same class and its derived classes. 
        
        // internal(ignore for now.):
            //  When we declare a type or type member as internal, it can be accessed only within the same assembly.
            //  An assembly is a collection of types (classes, interfaces, etc) and resources (data). 
            //  They are built to work together and form a logical unit of functionality.
            //  That's why when we run an assembly all classes and interfaces inside the assembly run together. 

        public void DoSomeShit()
        {
            IAmShit();
        }

        private void IAmShit()
        {
            Console.WriteLine("I Am Tired and Feeling Shitty.");
        }

    }
}

