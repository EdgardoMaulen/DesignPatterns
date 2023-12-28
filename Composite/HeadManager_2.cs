using System;

namespace Composite
{
    internal class HeadManager_2 : CEO, IEmployee
    {
        public override void Designation()
        {
            Console.WriteLine("My name is Jeff. My Boss is Edgardo");
        }
    }
}
