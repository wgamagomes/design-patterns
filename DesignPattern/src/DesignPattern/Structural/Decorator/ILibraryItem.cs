namespace DesignPattern.Structural.Decorator
{
    public interface ILibraryItem
    {
        int NumberOfCopies { get;  set; }

        void Display();
    }
}
