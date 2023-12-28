
using System;

namespace Adaptor
{
    internal class Sony : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("This is a Sony Laptop");
        }
    }
}
