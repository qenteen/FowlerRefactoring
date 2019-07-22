using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;   
        }

        public override double GetCost(int daysRented)
        {
            double cost = 2;
            if (daysRented > 2)
            {
                cost += (daysRented - 2) * 1.5;
            }
            return cost;
        }
    }
}
