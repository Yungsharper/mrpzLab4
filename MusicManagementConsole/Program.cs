using MusicLibraryLogic;

var musicLibrary = new MusicLibrary();

Console.WriteLine("Add 8 songs");

//Створюємо жанри, пісні та додаємо певні пісні до улюблених
Genre rock = new Genre("Rock");
Genre pop = new Genre("Pop");
Song s1 = new Song("Bohemian Rhapsode", "Queen", rock);
Song s2 = new Song("Smells Like Teen Spirit", "Nirvana", rock);
Song s3 = new Song("Stairway to Heaven", "Led Zeppelin", rock);
Song s4 = new Song("Hotel California", "Eagles", rock);
Song s5 = new Song("Shape of You", "Ed Sheeran", pop);
Song s6 = new Song("Roar", "Katy Perry", pop);
Song s7 = new Song("Happy", "Pharrell Williams", pop);
Song s8 = new Song("Uptown Funk", "Mark Ronson", pop);
musicLibrary.AddGenre(rock);
musicLibrary.AddGenre(pop);
musicLibrary.AddSong(s1);
musicLibrary.AddSong(s2);
musicLibrary.AddSong(s3);
musicLibrary.AddSong(s4);
musicLibrary.AddSong(s5);
musicLibrary.AddSong(s6);
musicLibrary.AddSong(s7);
musicLibrary.AddSong(s8);
musicLibrary.AddToFavorites(s1);
musicLibrary.AddToFavorites(s3);
musicLibrary.AddToFavorites(s5);

//Вивід улюблених пісень, що сортуються по назві
List<Song> sortedFavorites = musicLibrary.GetFavoritesSortedByNameDescending();
Console.WriteLine("\nSorted favorites songs by name:\n--------------------------------------------------------------");

foreach (var song in sortedFavorites)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

//Вивід пісень жанру рок, що сортуються по назві пісні
List<Song> sortedRock = musicLibrary.GetSongsForGenreSortedByNameDescending(rock);
Console.WriteLine("\nSorted songs by rock:\n--------------------------------------------------------------");

foreach (var song in sortedRock)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

//Вивід пісень жанру поп, що сортуються по назві пісні
List<Song> sortedPop = musicLibrary.GetSongsForGenreSortedByNameDescending(pop);
Console.WriteLine("\nSorted songs by pop:\n--------------------------------------------------------------");

foreach (var song in sortedPop)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

Console.WriteLine("\n\nAdd 4 new songs\n\n");

//Створюємо пісні та додаємо певні пісні до улюблених
Song s9 = new Song("Can't Stop the Feeling", "Justin Timberlake", pop);
Song s10 = new Song("Sweet Child O'Mine", "Guns N'Roses", rock);
Song s11 = new Song("Yesterday", "The Beatles");
Song s12 = new Song("The House of the Rising Sun");

musicLibrary.AddSong(s9);
musicLibrary.AddSong(s10);
musicLibrary.AddSong(s11);
musicLibrary.AddSong(s12);
musicLibrary.AddToFavorites(s9);
musicLibrary.AddToFavorites(s11);

//Вивід улюблених пісень, що сортуються по назві
sortedFavorites = musicLibrary.GetFavoritesSortedByNameDescending();
Console.WriteLine("\nSorted favorites songs by name:\n--------------------------------------------------------------");

foreach (var song in sortedFavorites)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

//Вивід пісень жанру рок, що сортуються по назві пісні
sortedRock = musicLibrary.GetSongsForGenreSortedByNameDescending(rock);
Console.WriteLine("\nSorted songs by rock:\n--------------------------------------------------------------");

foreach (var song in sortedRock)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

//Вивід пісень жанру поп, що сортуються по назві пісні
sortedPop = musicLibrary.GetSongsForGenreSortedByNameDescending(pop);
Console.WriteLine("\nSorted songs by pop:\n--------------------------------------------------------------");

foreach (var song in sortedPop)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

//Вивід пісень, що не мають жанру, вони сортуються по назві пісні
List<Song> sortedUndefined = musicLibrary.GetSongsForGenreSortedByNameDescending();
Console.WriteLine("\nSorted songs by undefined:\n--------------------------------------------------------------");

foreach (var song in sortedUndefined)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}

Genre hipHop = new Genre("Hip Hop");
Genre electronic = new Genre("Electronic");
List<Song> sortedHipHop = musicLibrary.GetSongsForGenreSortedByNameDescending(hipHop);
Console.WriteLine("\nSorted songs by Hip Hop:\n--------------------------------------------------------------");

foreach (var song in sortedHipHop)
{
    Console.WriteLine($"Name: {song.Name}, Author: {song.Author}\n--------------------------------------------------------------");
}