using System;

namespace MusicLibraryLogic
{
    public class Genre
    {
        public static readonly Genre Undefined = new Genre("Undefined");
        public string Name { get; set; }

        public Genre(string name)
        {
            Name = name;
        }
    }
}