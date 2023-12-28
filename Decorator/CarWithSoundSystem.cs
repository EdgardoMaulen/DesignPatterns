using System;

namespace Decorator
{
    public class CarWithSoundSystem:CarWithAC //Car
    {
        /*Here we inherit both features from the previous classes*/
        public override void CarType()
        {
            base.CarType();
            Console.WriteLine(" With Sound System");
        }

        //public override void CarType()
        //{
        //    Console.WriteLine("Car With Sound System Only");
        //}
    }

    /*Note:
        The commented lines are an alternative construction for this class in which we don't include the AC
        Typically we would use those lines in a different class.
     */
}
