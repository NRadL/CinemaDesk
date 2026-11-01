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

string? userChoice;
bool continueLoop = true;

do
{
    Console.Clear();
    
    Console.WriteLine("----------------------------------|");
    Console.WriteLine("1. Enter 1 to add movies");
    Console.WriteLine("2. Enter 2 to list all movies");
    Console.WriteLine("3. Enter 3 to list all screenings");
    Console.WriteLine("4. Enter 4 to exit");

    Console.Write("\nChoose an option: ");
    userChoice = Console.ReadLine();
    
    Int32.TryParse(userChoice, out int userChoiceNum);

    switch (userChoiceNum)
    {
        //add a movie
        case 1:
            
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
                
                Console.WriteLine();
                Console.Write("Do you want to add another movie? (y/N): ");
                string? anotherMovie = Console.ReadLine();

                if (anotherMovie?.Trim().ToLower() == "y")
                    continue;

                break;
            }
            break;
        
        // List all movies
        case 2:
            Movie.ListMovies(movies);

            Console.WriteLine();
            Console.Write("Press any key to return to the main menu.");
            Console.ReadKey();
            break;
        
        // List all screenings
        case 3:
            Screening.ListScreenings(screenings, movies);
            
            Console.WriteLine();
            Console.Write("Press any key to return to the main menu.");
            Console.ReadKey();
            break;
        
        // Exit the app
        case 4:
            continueLoop = false;
            break;
        
        default:
            Console.WriteLine("Invalid option. Try again.");
            Console.ReadLine();
            break;
    }
    
} while (continueLoop);