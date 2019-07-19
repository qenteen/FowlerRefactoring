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
            string result = $"Прокат {Name}\n";

            foreach (var rental in _rentals)
            {
                // Вывод результатов для каждого проката
                result += $"\t{rental.Movie.Title}\t{rental.GetCost()}\n";
            }

            // Добавление колонтитула
            result += $"Сумма задолженности: {GetTotalRentalCost()}\n";
            result += $"Вы заработали {GetTotalFrequentRenterPoints()} бонусных очков";

            return result;
        }

        private double GetTotalRentalCost()
        {
            double totalCost = 0;
            foreach (var rental in _rentals)
            {
                totalCost += rental.GetCost();
            }

            return totalCost;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int totalPoints = 0;
            foreach (var rental in _rentals)
            {
                totalPoints += rental.GetFrequentRenterPoints();
            }

            return totalPoints;
        }
    }
}
