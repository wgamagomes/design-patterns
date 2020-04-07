namespace DesignPattern.Structural.Decorator
{
    public class LibraryItemDecorator : ILibraryItem
    {
        public int NumberOfCopies => throw new System.NotImplementedException();

        protected ILibraryItem libraryItem;     

        public LibraryItemDecorator(ILibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public void Display()
        {
            
        }
    }
}
