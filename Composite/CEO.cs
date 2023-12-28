using System;

namespace Composite
{
    class CEO : IEmployee
    {
        //take note of the word virtual in this method. Without it, the implementation on the derived classes won't work
        public virtual void Designation()
        {
            Console.WriteLine("I'm Edgardo. The CEO of this company");
        }
    }
}
