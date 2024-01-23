using System;

namespace MusicLibraryLogic
{
    public class Song
    {
        public static readonly string UndefinedAuthor = "Undefined";
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre SongGenre { get; set; }

        public Song(string name, string author = null, Genre genre = null)
        {
            Name = name;
            Author = author ?? UndefinedAuthor;
            SongGenre = genre ?? Genre.Undefined;
        }
    }
}
