using DesignPattern.Structural.Decorator;

namespace DesignPattern.Structural
{
    public class BorrowableItem : LibraryItemDecorator
    {
        public BorrowableItem(ILibraryItem libraryItem)
            :base(libraryItem)
        {

        }
    }
}
