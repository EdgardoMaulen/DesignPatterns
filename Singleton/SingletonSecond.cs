namespace Singleton
{
    public sealed class SingletonSecond
    {
        public int Data = 0;
        private static SingletonSecond instance;
        private static object syncRoot = new object(); //Locking mechanism

        private SingletonSecond() { }

        public static SingletonSecond Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null) instance = new SingletonSecond();
                    }
                }
                return instance;
            }
        }
    }
}
