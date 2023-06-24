using ExceptionExercise.Enums;
using ExceptionExercise.Models;

namespace ExceptionExercise
{
    internal class Program
    {
        static void Main()
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 3);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);

            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 3);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);

            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.Movies = MovieSet1;

            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.Movies = MovieSet2;

            Cinema selectedCinema = null;
            
            try
            {
                selectedCinema = CinemaUI(cinema1, cinema2);

                Console.WriteLine("Movies in this cinema:\n1. Show all movies\n2. Show by genre");

                int moviesInput = int.Parse(Console.ReadLine());

                // It will hold the user selection of movie
                Movie userSelectedMovie = null;

                if (moviesInput == 1)
                {
                    foreach (Movie movie in selectedCinema.Movies)
                        Console.WriteLine($" - {movie.Title}");

                    userSelectedMovie = UserMovieSelection(selectedCinema.Movies);
                }

                if (moviesInput == 2)
                {
                    Console.WriteLine("Enter favourite genre: \n1.Comendy\n2.Horror\n3.Action\n4.Drama\n5.SciFi");

                    int genreInput = int.Parse(Console.ReadLine());

                    Genre selectedGenre = (Genre)genreInput;

                    List<Movie> selectedGenreMovies = selectedCinema.Movies
                        .Where(m => m.Genre == selectedGenre)
                        .ToList();

                    foreach (Movie movie in selectedGenreMovies)
                        Console.WriteLine($" - {movie.Title}");

                    userSelectedMovie = UserMovieSelection(selectedGenreMovies);
                }

                selectedCinema.MoviePlaying(userSelectedMovie);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was a problem, {ex.Message}");
            }
        }

        private static Movie UserMovieSelection(List<Movie> movies) 
        {
            Console.WriteLine("Pick movie to play");

            string userMovieSelection = Console.ReadLine();

            // original name: The Ring
            // user input:    RING

            // to lower = the ring - ring

            userMovieSelection = userMovieSelection.ToLower();

            Movie selectedMovie = movies.Where(m => m.Title.ToLower().Contains(userMovieSelection))
                .FirstOrDefault();

            return selectedMovie;
        }

        private static Cinema CinemaUI(Cinema cinema1, Cinema cinema2)
        {
            Console.WriteLine("Please pick the cinema from the list: ");
            Console.WriteLine("1. Cineplex");
            Console.WriteLine("2. Milenium");

            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                return cinema1;
            }
            else if (userSelection == 2)
            {
                return cinema2;
            }
            else
            {
                throw new Exception("Not valid input");
            }
        }
    }
}