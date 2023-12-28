using System;

namespace Decorator
{
    public class CarWithAC:Car
    {
        //we inherit from car class and override the constructor method to indicate this car has AC
        public override void CarType()
        {
            Console.Write("Car has AC");
        }
    }
}
