using System.Collections.Generic;
using Cinema_Desk;

int nextMovieId = 1;
List<Movie> movies = new List<Movie>();


movies.Add(new Movie(nextMovieId++, "Obsesja", 108, "Horror"));
movies.Add(new Movie(nextMovieId++, "Shronk", 227, "Comedy"));
movies.Add(new Movie(nextMovieId++, "Superman", 209, "Action"));

List<Screening> screenings = new List<Screening>();
screenings.Add(new Screening(1, 1, new DateTime(2026, 11, 7, 18, 30, 0), "A", 80));
screenings.Add(new Screening(2, 3, new DateTime(2026, 11, 7, 20, 0, 0), "B", 120));
screenings.Add(new Screening(3, 99, new DateTime(2026, 11, 8, 19, 0, 0), "A", 80));

//add a movie
while (true)
{
    Console.Write("Enter the title of the movie: ");
    string? title = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(title))
    {
        Console.WriteLine("Title can't be empty");
        continue;
    }

    int durationMinute;
    while (true)
    {
        Console.Write("Enter the duration of the movie: ");
        if (int.TryParse(Console.ReadLine(), out durationMinute) && durationMinute > 0)
            break;

        Console.WriteLine("Please enter a positive number");
    }

    string? genre;
    while (true)
    {
        Console.Write("Enter the genre of the movie: ");
        genre = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(genre))
            break;

        Console.WriteLine("Genre can't be empty");
    }

    movies.Add(new Movie(nextMovieId++, title, durationMinute, genre));

    Console.Write("Do you want to add another movie? (y/N): ");
    string? anotherMovie = Console.ReadLine();

    if (anotherMovie?.Trim().ToLower() == "y")
        continue;

    break;
}


// List all movies
foreach (var movie in movies)
{
    Console.WriteLine(movie);
}

// List all screenings
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