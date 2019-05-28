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
            return $"\nThe company's Id is: {Id}; " +
            	$"\n The company's Name is: {Name}; " +
            	$"\n Its volume is: {Volume} and shares: ${Price}; " +
            	$"\n The Stock ticket is: {Symbol};" +
            	$"\n It worths {Price * Volume}";
        }
    }
}
