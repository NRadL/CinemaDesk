using System.Collections.Generic;
using Cinema_Desk;

List<Movie> movies = new List<Movie>();

movies.Add(new Movie("Obsesja", 108, "Horror"));
movies.Add(new Movie("Shronk", 227, "Comedy"));
movies.Add(new Movie("Superman", 209, "Action"));

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

    movies.Add(new Movie(title, durationMinute, genre));

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

// Look up a movie
Console.Write("Enter the title of the movie to check if it exists: ");

string? userTitle = Console.ReadLine();
bool found = false;

foreach (var movie in movies)
{
    if (movie.Title == userTitle)
    {
        found = true;
        break;
    }
}
Console.WriteLine(found ? "found" : "not found");