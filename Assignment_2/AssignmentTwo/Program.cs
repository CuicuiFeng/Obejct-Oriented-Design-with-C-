using System;

namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            stock.demo();
            stock.result();
            Random r = new Random();
            int random = r.Next()%100+1;
            stock.Update(random);
            stock.result();
        }
    }
}
