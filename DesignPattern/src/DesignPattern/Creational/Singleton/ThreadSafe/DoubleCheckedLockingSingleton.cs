namespace DesignPattern.Creational.Singleton.ThreadSafe
{
    public class DoubleCheckedLockingSingleton
    {
        private static DoubleCheckedLockingSingleton _instance;
        public static int Counter = 0;
        private static readonly object Instancelock = new object();

        private DoubleCheckedLockingSingleton()
        {
            Counter++;
        }

        public static DoubleCheckedLockingSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Instancelock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedLockingSingleton();
                        }                       
                    }
                }

                return _instance;
            }
        }

        public string GetDetails(string message)
        {
            return $"Counter Value: {Counter} - {message}.";
        }
    }
}
