using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "More About Classes...")); //Prints in the middle on console

            /// <summary>
            /// Here we are Making a myCar Object of class Car which is a ? nullable Reference type.
            /// myCar holds a reference to an instance obj of Car Class in Memory
            /// 
            /// We can use the myCar reference to instance to set value of attributes/properties fields.
            /// </summary>
            /// <returns></returns>

            Car? myCar = new Car();

            myCar.make = "Lamborghini";
            myCar.model = "Hurracan";
            myCar.year = 2018;
            myCar.colour = "Yellow";

            Car? myOtherCar;     //Here we are creating a new obj instance of Car class 
            myOtherCar = myCar; //setting myOtherCar to teh address as reference of myCar

            Console.WriteLine($"{myOtherCar.make} {myOtherCar.model} {myOtherCar.year} {myOtherCar.colour}"); 
            //Printing properties by myOtherCar Instance which refers to MyCar instrance

            myOtherCar.model = "Aventador"; //Changing a properties by myOtherCar Instance which refers to MyCar instrance

            Console.WriteLine($"{myCar.make} {myCar.model} {myCar.year} {myCar.colour}");//Printing properties by myCar Instance

            myOtherCar = null; //Nulling the myOtherCar value (It losses the refernce to Obj instance)
            //Once all reference to a instance are lost the C# Garbage Collector Removes the Object Instance from Memory.

            //Console.WriteLine($"{myOtherCar.make} {myOtherCar.model} {myOtherCar.year} {myOtherCar.colour}");

            myCar = null;   //Nulling the myOtherCar value (It losses the refernce to Obj instance)


            
        }
    }

    class Car
    {
        public string? make { get; set; }
        public string? model { get; set; }
        public int year { get; set; }   
        public string? colour { get; set; }

    }
}
