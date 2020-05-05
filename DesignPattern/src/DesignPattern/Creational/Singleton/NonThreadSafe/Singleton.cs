namespace DesignPattern.Creational.Singleton.NonThreadSafe
{
    public class Singleton
    {
        private static Singleton _instance;
        public static int Counter = 0;

        private Singleton()
        {
            Counter++;
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
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
