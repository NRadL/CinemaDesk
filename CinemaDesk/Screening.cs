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
}