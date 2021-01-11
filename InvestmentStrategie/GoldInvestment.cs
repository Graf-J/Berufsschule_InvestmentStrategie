using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentStrategie
{
    class GoldInvestment : IInvestmentStrategy
    {
        public void Invest(double investedMoney)
        {
            Console.WriteLine($"Du hast {investedMoney} Euro in Gold investiert!");
        }
        public string getInfo()
        {
            return "Gold";
        }
    }
}
