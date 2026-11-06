namespace Cinema_Desk;

public class CinemaService
{
    
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

    public static void ListScreenings(List<Screening> screenings, List<Movie> movies)
    {
        
        if (screenings.Count == 0)
        {
            Console.WriteLine("No screenings in the list.");
            return;
        }
        
        foreach (var screening in screenings)
        {
            Movie? movie = movies.FirstOrDefault(m => m.Id == screening.MovieId);

            if (movie == null)
            {
                Console.WriteLine($"{screening} -> movie #{screening.MovieId} not found");
                continue;
            }

            Console.WriteLine($"{movie.Title} ({movie.DurationMinutes} min) - {screening}");
        }
    }
}