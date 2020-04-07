namespace DesignPattern.Structural.Decorator
{
    public class LibraryItemDecorator : ILibraryItem
    {
        private ILibraryItem _libraryItem;

        public int NumberOfCopies
        {
            get
            {
                return _libraryItem.NumberOfCopies;
            }
        }

        public LibraryItemDecorator(ILibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public virtual void Display()
        {
            _libraryItem.Display();
        }
    }
}
