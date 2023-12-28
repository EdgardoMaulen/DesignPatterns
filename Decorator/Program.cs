using System;

namespace Decorator
{
    class Program
    {

        /*
         This pattern is perfect for when you need an object with certain features but those features are not needed at all times. In this example with two types of cars
        one with AC and one with AC + Sound system. 
         */
        static void Main(string[] args)
        {
            Car carAC = new CarWithAC();
            carAC.CarType();
            Console.WriteLine("\n");
            Car carFull = new CarWithSoundSystem();
            carFull.CarType();
            Console.ReadKey();
        }
    }
}
