using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class InvestmentCompany
    {
        public InvestmentCompany()
        {
        }

        public void Add(AbstractStock s)
        {
        }

        public void Show()
        {
        }

        public static void demo()
        {
            List<AbstractStock> portfolio = new List<AbstractStock>
            {
                new Stock { Id = 1, Name = "Microsoft", Price = 126.24, Symbol = "MSFT", Volume = 10 },
                new Stock { Id = 2, Name = "IBM", Price = 132.28, Symbol = "IBM", Volume = 20 },
                new Stock {Id = 3, Name = "Apple", Price = 178.79, Symbol = "AAPL", Volume = 30},
                new Stock {Id = 4, Name = "Google", Price = 1138.61, Symbol = "GOOGL", Volume = 40},
                new Stock {Id = 5, Name = "Starbucks", Price = 76.15, Symbol = "SBUX", Volume = 50}
            };

            foreach(Stock stock in portfolio)
            {
                Console.WriteLine(stock);
            }
        }
    }
}
