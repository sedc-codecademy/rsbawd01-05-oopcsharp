using ExceptionExercise.Enums;
using System;
using System.Collections.Generic;
namespace ExceptionExercise.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;

            if (rating < 1 || rating > 5)
                throw new Exception("Rating value should be between 1 and 5"); 

            Rating = rating;

            TicketPrice = 5 * rating;
        }
    }
}
