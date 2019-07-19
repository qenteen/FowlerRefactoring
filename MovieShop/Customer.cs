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
                frequentRenterPoints += rental.GetFrequentRenterPoints();

                // Вывод результатов для каждого проката
                result += $"\t{rental.Movie.Title}\t{rental.GetCost()}\n";

                totalAmount += rental.GetCost();
            }

            // Добавление колонтитула
            result += $"Сумма задолженности: {totalAmount}\n";
            result += $"Вы заработали {frequentRenterPoints} бонусных очков";

            return result;
        }
    }
}
