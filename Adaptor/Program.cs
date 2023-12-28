using System;

namespace Adaptor
{
    internal class Program
    {
        /*
         * We use the adaptor pattern when different classes need to talk to each other. For this we set an adaptor class which will take the job of executing the method
         * that corresponds to the requested class. In this example we have a "person" class that requests the execution of the method ShowModel based on the computer he is
         * "Switching On".
         */
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SwitchOn(new HP());      //uses HP laptop
            person.SwitchOn(new Compact()); //uses Compact laptop
            Console.ReadKey();
        }
    }
}
