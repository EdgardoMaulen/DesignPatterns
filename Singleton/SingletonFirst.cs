namespace Singleton
{
    internal class SingletonFirst
    {
        public static int counter = 0;
        private SingletonFirst()
        {
            //private constructor = no creation of this class
        }

        public static int ReturnCount()
        {
            return counter;
        }

        public static void IncreaseCount()
        {
            counter++;
        }
    }
}
