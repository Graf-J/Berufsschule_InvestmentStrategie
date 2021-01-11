using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentStrategie
{
    class StockMarketInvestment : IInvestmentStrategy
    {
        public void Invest(double investedMoney)
        {
            Console.WriteLine($"Du hast {investedMoney} Euro in Aktien investiert!");
        }

        public string getInfo()
        {
            return "Aktien";
        }
    }
}
