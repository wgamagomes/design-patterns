using System;
using System.Diagnostics;

namespace DesignPattern.Structural.Decorator
{
    public class Book : ILibraryItem
    {
        public int NumberOfCopies { get; private set; }
        public string Author { get; private set; }
        public string Title { get; private set; }

        public Book(string author, string title, int numberOfCopies)
        {
            Author = author;
            Title = title;
            NumberOfCopies = numberOfCopies;
        }

        public void Display()
        {
            Debug.WriteLine($"[Book] Title: {Title} Author: {Author} Copies: {NumberOfCopies}");
        }
    }
}
