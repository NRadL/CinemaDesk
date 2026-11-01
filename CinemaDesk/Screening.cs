namespace Cinema_Desk;

public class Screening
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public DateTime StartTime { get; set; }
    public string Room { get; set; } 
    public int SeatsTotal { get; set; }

    public Screening(int id, int movieId, DateTime startTime, string room, int seatsTotal)
    {
        Id = id;
        MovieId = movieId;
        StartTime = startTime;
        Room = room;
        SeatsTotal = seatsTotal;
    }
    
    public override string ToString()
    {
        return $"#{Id} | {StartTime:yyyy-MM-dd HH:mm} | Room {Room} | {SeatsTotal} seats";
    }

    public static void ListScreenings(List<Screening> screenings, List<Movie> movies)
    {
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