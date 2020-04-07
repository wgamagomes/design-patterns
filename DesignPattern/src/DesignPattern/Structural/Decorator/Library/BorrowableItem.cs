using DesignPattern.Structural.Decorator;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPattern.Structural
{
    public class BorrowableItem : LibraryItemDecorator
    {
        private List<string> _borrowers;

        public BorrowableItem(ILibraryItem libraryItem)
            : base(libraryItem)
        {
            _borrowers = new List<string>();
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            LibraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            LibraryItem.NumberOfCopies++;
        }

        public override void Display()
        {
            base.Display();
            foreach (var borrower in _borrowers)
            {
                Debug.WriteLine($" borrower: {borrower}");
            }
        }
    }
}
