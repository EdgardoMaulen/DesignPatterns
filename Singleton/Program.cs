using System;

namespace Singleton
{
    class Program
    {
        /*
         The purpose of the singleton is to create a class that locks out the possibility of creating a new instance of the class. If a method or data is needed
        from that class, then it will be called from the class itself and not an instance of said class.

        In the first example we have the classic style of a single class use.
        In the second example we allowed the possibility to create a single entity of said class but the possibility of using a new instance is locked by checking if
        the instance created is null. If it's null it creates a new instance. If it's not null it returns said instance.
         */
        static void Main(string[] args)
        {

            //singletonFirst
            Console.WriteLine("Before Increase:" + SingletonFirst.counter);
            Console.ReadLine();
            SingletonFirst.IncreaseCount();
            Console.WriteLine("After Increase:" + SingletonFirst.counter);
            Console.ReadLine();
            Console.WriteLine(" ");

            //SingletonSecond
            SingletonSecond s = SingletonSecond.Instance; //Create singleton instance
            s.Data = 100; //add data

            Console.WriteLine("Data in S Object: " + s.Data); //show data

            SingletonSecond s1 = SingletonSecond.Instance; //Create a second instance
            Console.WriteLine("Data in S1 Object: " + s1.Data); //shows data from old instance
            Console.ReadLine();
        }
    }
}
