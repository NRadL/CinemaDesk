namespace Cinema_Desk;

public class Screenings
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public DateTime StartTime { get; set; }
    public string Room { get; set; } 
    public int SeatsTotal { get; set; }

    public Screenings(int movieId, DateTime startTime, string room, int seatsTotal)
    {
        MovieId = movieId;
        StartTime = startTime;
        Room = room;
        SeatsTotal = seatsTotal;
    }
}