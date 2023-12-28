using System;

namespace Composite
{
    class AreaManager : HeadManager_1, IEmployee
    {
        public new void Designation()
        {
            Console.WriteLine("I am Joe Biden. My boss is Elon");
        }
    }
}
