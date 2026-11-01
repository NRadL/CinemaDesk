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
}