using System;

namespace CodeFirstExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StockContext sc = new StockContext();
            Stock MSFT = sc.Stocks.Find(1);
            Stock AAPL = sc.Stocks.Find(2);

            Console.WriteLine(MSFT.Name);
            Console.WriteLine(MSFT.Price);
            Console.WriteLine(MSFT.Symbol);
            Console.WriteLine();


            Console.WriteLine(AAPL.Name);
            Console.WriteLine(AAPL.Price);
            Console.WriteLine(AAPL.Symbol);
        }
    }
}
