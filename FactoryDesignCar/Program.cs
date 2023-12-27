using System;

namespace FactoryDesignCar
{
    class Program
    {
        static void Main(string[] args)
        {
            ISupplier obj = CarFactory.GiveMyCar(0);
            obj.CarSupplier();
            obj = CarFactory.GiveMyCar(1);
            obj.CarSupplier();
            Console.ReadKey();
        }
    }
}