namespace FactoryDesignCar
{

    //This is the class that takes every other class and provides the object based on the requirements of the client
    class CarFactory
    {
        public static ISupplier GiveMyCar(int Key)
        {
            if (Key == 0) return new Namo();
            else if (Key == 1) return new Alto();
            else return null;
        }

        //note: As you may have noticed, the conditionals could be perfectly replaced by a switch statement
    }
}
