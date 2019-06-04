using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace AssignmentTwo
{
    public class Stock : AbstractStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Symbol { get; set; }
        public int Volume { get; set; }
        public List<Stock> portfolio;

        public Stock() 
        {
        }

        public Stock(int id, string name, double price, string symbol, int volumn)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Symbol = symbol;
            this.Volume = volumn;
        }


        public override void Update(int PriceChange)
        {
            foreach(Stock stock in portfolio)
            {
                stock.Price += PriceChange;
            }


        }

        public void demo()
        {
            List<string> StockCSV = new List<string>
            {
                "1, Microsoft,126.24, MSFT, 10",
                "2, IBM,132.28, IBM, 20",
                "3, Apple,178.79, AAPL, 30",
                "4, Google,1138.61, GOOGL, 40",
                "5, Starbucks,76.15, SBUX, 50",
                "6, Lenovi,14, LNVGL, 60",
                "7, Dell,55.86, DELL, 70",
                "8, Bank of America,132, BAC, 80",
                "9, Philips,39.80, PHG, 90",
                "10, Amazon,1692.69, AMZN, 100"
            };

            FileUtil fileUtil = new FileUtil();
            fileUtil.WriteAll("WriteStockCsv", StockCSV);

            List<String> ReadStockCSV = new List<string>();
            fileUtil.ReadAll("WriteStockCsv", ReadStockCSV);

            this.portfolio = new List<Stock>();

            foreach(var s in ReadStockCSV)
            {
                string StockData = s;
                char delimiter = ',';  // Use space as delimeter
                string[] tokens = StockData.Split(delimiter);

                portfolio.Add(new Stock(int.Parse(tokens[0]), tokens[1], double.Parse(tokens[2]), tokens[3], int.Parse(tokens[4])));
                // Stock stock = new Stock(Int32.Parse(tokens[0]), tokens[1], double.Parse(tokens[2]), tokens[3], Int32.Parse(tokens[4]);

            }

        }

        public void result()
        {
            foreach(Stock stock in portfolio)
            {
                Console.WriteLine(stock);
            }
        }

        public override string ToString()
        {
            return $"\nThe company's Id is: {Id}; " +
                $"\n The company's Name is: {Name}; " +
                $"\n Its volume is: {Volume} and shares: ${Price}; " +
                $"\n The Stock ticket is: {Symbol};" +
                $"\n It worths {Price * Volume}";
        }
    }
}
