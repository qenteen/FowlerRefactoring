using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    /// <summary>
    /// Содержит данные о прокате фильма
    /// </summary>
    class Rental
    {
        private Movie _movie;
        private int _daysRented;

        public Movie Movie { get => _movie; }
        public int DaysRented { get => _daysRented; }

        public Rental(Movie movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }
    }
}
