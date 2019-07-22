using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    /// <summary>
    /// Содержит информацию о фильме
    /// </summary>
    class Movie
    {
        public const int Regular = 0;
        public const int NewRelease = 1;
        public const int Childrens = 2;

        private string _title;
        private int _priceCode;

        public string Title { get => _title; }
        public int PriceCode {
            get => _priceCode;
            set => _priceCode = value;
        }

        public Movie(string title, int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
        }

        public double GetCost(int daysRented)
        {
            double cost = 0;

            switch (PriceCode)
            {
                case Regular:
                    cost += 2;
                    if (daysRented > 2)
                    {
                        cost += (daysRented - 2) * 1.5;
                    }
                    break;
                case NewRelease:
                    cost += daysRented * 3;
                    break;
                case Childrens:
                    cost += 1.5;
                    if (daysRented > 3)
                    {
                        cost += (daysRented - 3) * 1.5;
                    }
                    break;
            }

            return cost;
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            // Двойной бонус за долгий прокат новинки
            if (PriceCode == NewRelease && daysRented > 1)
            {
                return 2;
            }
            return 1;
        }
    }
}
