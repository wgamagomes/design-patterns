namespace DesignPattern.Creational.Singleton.ThreadSafe
{
    public class LockSingleton
    {
        private static LockSingleton _instance;
        public static int Counter = 0;
        private static readonly object Instancelock = new object();

        private LockSingleton()
        {
            Counter++;
        }

        public static LockSingleton Instance
        {
            get
            {
                lock (Instancelock)
                {
                    if (_instance == null)
                    {
                        _instance = new LockSingleton();
                    }

                    return _instance;
                }
            }
        }

        public string GetDetails(string message)
        {
            return $"Counter Value: {Counter} - {message}.";
        }
    }
}
