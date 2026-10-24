namespace Cinema_Desk;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int DurationMinutes { get; set; }
    public string Genre { get; set; }

    public Movie(string title, int durationMinutes, string genre)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"{Title} ({DurationMinutes} min, {Genre})";
    }

    public bool IsLong()
    {
        return DurationMinutes > 120;
    }

    public string ShortInfo()
    {
        return $"{Title} [{Genre}]";
    }
}