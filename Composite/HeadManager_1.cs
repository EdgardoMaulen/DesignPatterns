using System;

namespace Composite
{
    internal class HeadManager_1 : CEO, IEmployee
    {
        public override void Designation()
        {
            Console.WriteLine("I am Elon. My Boss is Edgardo");
        }
    }
}
