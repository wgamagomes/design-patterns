using System.Diagnostics;

namespace DesignPattern.Structural.Decorator
{
    public class Video : ILibraryItem
    {
        public int NumberOfCopies { get; private set; }
        public string Director { get; private set; }
        public string Title { get; private set; }
        public int PlayTime { get; private set; }


        public Video(string director, string title, int numberOfCopies, int playTime)
        {
            Director = director;
            Title = title;
            NumberOfCopies = numberOfCopies;
            PlayTime = playTime;
        }

        public void Display()
        {
            Debug.WriteLine($"[Vídeo] Title: {Title} Director: {Director} Copies: {NumberOfCopies} Playtime: {PlayTime}");

 
        }
    }
}
