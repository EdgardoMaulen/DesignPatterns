using System;

namespace Adaptor
{
    class HP : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("This is an HP Laptop");
        }
    }
}
