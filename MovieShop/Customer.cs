using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    /// <summary>
    /// Клиент проката
    /// </summary>
    class Customer
    {
        private List<Rental> _rentals = new List<Rental>(10);

        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string GetStatement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = $"Прокат {Name}\n";

            foreach (var rental in _rentals)
            {
                double thisAmount = rental.GetCost();

                // Начисление бонусных очков
                frequentRenterPoints++;

                // Бонус за двухдневный прокат новинки
                if (rental.Movie.PriceCode == Movie.NewRelease
                    && rental.DaysRented > 1)
                {
                    frequentRenterPoints++;
                }

                // Вывод результатов для каждого проката
                result += $"\t{rental.Movie.Title}\t{thisAmount}\n";

                totalAmount += thisAmount;
            }

            // Добавление колонтитула
            result += $"Сумма задолженности: {totalAmount}\n";
            result += $"Вы заработали {frequentRenterPoints} бонусных очков";

            return result;
        }
    }
}
