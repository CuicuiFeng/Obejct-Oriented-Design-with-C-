using System;
namespace Assignment1
{
    public class Stock : AbstractStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Symbol { get; set; }
        public int Volume { get; set; }

        public override double Update(int percentChange)
        {
            return 0;
        }

        public Stock()
        {
        }

        public override string ToString()
        {
            return $"#{Id} {Volume} shares: ${Price} (%) {Symbol} \" worth ${Price * Volume}";
        }
    }
}
