namespace DesignPattern.Structural.Adapter.Definition
{
    public class Client
    {
        private Target _target;

        public Client()
        {
            _target = new Adapter(); //could this object be injected  here in this constructor
        }

        public void Request()
        {
            _target.DoSomething();
        }
    }
}
