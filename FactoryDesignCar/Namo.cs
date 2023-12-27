using System;

namespace FactoryDesignCar
{
    internal class Namo : ISupplier
    {
        //Using the Isupplier interface forces us to implement the methods contained in the Interface
        public void CarSupplier()
        {
            Console.WriteLine("I am Nano supplier");
        }
    }
}
