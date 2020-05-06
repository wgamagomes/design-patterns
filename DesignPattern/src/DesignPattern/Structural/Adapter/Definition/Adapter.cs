namespace DesignPattern.Structural.Adapter.Definition
{
    public class Adapter : Target
    {
        private Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public override void DoSomething()
        {
            // Possibly do some other work  and then call DoSomethingElse method
            _adaptee.DoSomethingElse();
        }
    }
}
