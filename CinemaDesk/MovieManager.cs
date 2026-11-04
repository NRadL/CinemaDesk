namespace Cinema_Desk;

public class MovieManager
{
    public static int CountLongMovies(List<Movie> movies)
    {
        int count = 0;

        foreach (var movie in movies)
        {
            if (movie.IsLong())
                count++;
        }

        return count;
    }

    public static double AverageMovieLength(List<Movie> movies)
    {
        if (movies.Count == 0)
            return 0;

        double sum = 0;
        foreach (var movie in movies)
        {
            sum += movie.DurationMinutes;
        }

        return sum / movies.Count;
    }

    public static void CountMovies(List<Movie> movies)
    {
        Console.WriteLine(movies.Count);
    }

    public static bool RemoveMovie(List<Movie> movies, int id)
    {
        var movie = movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
            return false;
        
        return movies.Remove(movie);
    }

    public static bool ChangeMovie(List<Movie> movies, int id, string newGenre)
    {
        var movie = movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
            return false;

        movie.Genre = newGenre;
        return true;
    }
}