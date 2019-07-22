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
        Price _priceState;
        public const int Regular = 0;
        public const int NewRelease = 1;
        public const int Childrens = 2;

        public string Title { get; }
        public int PriceCode
        { 
            get => _priceState.GetPriceCode(); 
            set
            {
                switch (value)
                {
                    case Regular:
                        _priceState = new RegularPrice();
                        break;
                    case NewRelease:
                        _priceState = new NewReleasePrice();
                        break;
                    case Childrens:
                        _priceState = new ChildrensPrice();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("priceCode");
                }
            }
        }

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public double GetCost(int daysRented)
        {
            return _priceState.GetCost(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return _priceState.GetFrequentRenterPoints(daysRented);
        }
    }
}
