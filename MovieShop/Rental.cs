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

        public double GetCost()
        {
            double cost = 0;

            switch (Movie.PriceCode)
            {
                case Movie.Regular:
                    cost += 2;
                    if (DaysRented > 2)
                    {
                        cost += (DaysRented - 2) * 1.5;
                    }
                    break;
                case Movie.NewRelease:
                    cost += DaysRented * 3;
                    break;
                case Movie.Childrens:
                    cost += 1.5;
                    if (DaysRented > 3)
                    {
                        cost += (DaysRented - 3) * 1.5;
                    }
                    break;
            }

            return cost;
        }
    }
}
