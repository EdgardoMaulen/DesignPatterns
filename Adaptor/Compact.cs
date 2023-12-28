using System;

namespace Adaptor
{
    internal class Compact : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("This is a Compact Laptop");
        }
    }
}
