using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var terminator = new Movie("Terminator", 0);
            var matrix = new Movie("Matrix", 1);
            var antz = new Movie("Antz", 2);

            var customer = new Customer("John Doe");
            customer.AddRental(new Rental(matrix, 2));
            customer.AddRental(new Rental(terminator, 3));
            customer.AddRental(new Rental(antz, 1));

            Console.WriteLine(customer.GetStatement());
            Console.ReadKey();
        }
    }
}
