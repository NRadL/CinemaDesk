namespace Cinema_Desk;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int DurationMinutes { get; set; }
    public string Genre { get; set; }

    public Movie(int id, string title, int durationMinutes, string genre)
    {
        Id = id;
        Title = title;
        DurationMinutes = durationMinutes;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"{Title} ({DurationMinutes} min, {Genre})";
    }

    public static void ListMovies(List<Movie> movies)
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No movies in the list.");
            return;
        }

        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }

    public bool IsLong()
    {
        return DurationMinutes > 120;
    }

    public static void ListLongMovies(List<Movie> movies)
    {
        bool foundLong = false;

        if (movies.Count == 0)
        {
            Console.WriteLine("No movies in the list.");
            return;
        }


        foreach (var movie in movies)
        {
            if (movie.IsLong())
            {
                Console.WriteLine($"{movie} - long movie");
                foundLong = true;
            }
        }

        if (!foundLong)
            Console.WriteLine("No long movies in the list.");
    }
    
}