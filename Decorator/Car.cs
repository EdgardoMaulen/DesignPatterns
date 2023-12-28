using System;

namespace Decorator
{
    public class Car
    {
        /*This is the base class. As you can see this class is public and not abstract meaning we can build a car with none of the features*/
        public virtual void CarType()
        {
            Console.WriteLine("Simple Car");
        }
    }
}
