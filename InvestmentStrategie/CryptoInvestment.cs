using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentStrategie
{
    class CryptoInvestment : IInvestmentStrategy
    {
        public void Invest(double investedMoney)
        {
            Console.WriteLine($"Du hast {investedMoney} Euro in Crypto investiert!");
        }
        public string getInfo()
        {
            return "Crypto";
        }
    }
}
