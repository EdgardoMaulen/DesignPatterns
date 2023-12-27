using System;

namespace FactoryDesignCar
{
    internal class Alto : ISupplier
    {
        public void CarSupplier()
        {
            //Using the Isupplier interface forces us to implement the methods contained in the Interface
            Console.WriteLine("I am an Alto supplier");
        }
    }
}
