using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    class ChildrensPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Childrens;
        }

        public override double GetCost(int daysRented)
        {
            double cost = 1.5;
            if (daysRented > 3)
            {
                cost += (daysRented - 3) * 1.5;
            }
            return cost;
        }
    }
}
