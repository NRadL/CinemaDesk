namespace Cinema_Desk;

public class Reservation
{
    public int Id { get; set; }
    public int ScreeningId { get; set; }
    public int SeatCount { get; set; }
    public ReservationStatus  Status { get; private set; }
    
    public Reservation(int id, int screeningId, int seatCount, ReservationStatus status)
    {
        Id = id;
        ScreeningId = screeningId;
        SeatCount = seatCount;
        Status = ReservationStatus.Active;
    }

    public override string ToString()
    {
        return $"#{Id} | Screening #{ScreeningId} | {SeatCount} seats | {Status}";
    }
    
    public void Cancel()
    {
        Status = ReservationStatus.Cancelled;
    }
}