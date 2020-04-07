namespace DesignPattern.Structural.Decorator
{
    public class LibraryItemDecorator : ILibraryItem
    {
        public ILibraryItem LibraryItem { get; protected set; }
        public int NumberOfCopies { get => LibraryItem.NumberOfCopies; set => throw new System.NotImplementedException(); }

        public LibraryItemDecorator(ILibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        public virtual void Display()
        {
            LibraryItem.Display();
        }
    }
}
