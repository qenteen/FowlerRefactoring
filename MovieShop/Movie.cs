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
    }
}
