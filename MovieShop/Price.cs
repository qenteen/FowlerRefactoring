using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    abstract class Price
    {
        public abstract int GetPriceCode();
        public abstract double GetCost(int daysRented);
        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}
