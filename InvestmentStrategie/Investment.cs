using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentStrategie
{
    class Investment
    {
        private double investmentMoney;
        private bool talkedToBankEmployee;
        private IInvestmentStrategy investmentStrategy;

        public Investment(double investmentMoney)
        {
            if (investmentMoney > 0)
            {
                this.investmentMoney = investmentMoney;
            } 
            else
            {
                Console.WriteLine("Es kann kein negativer Betrag investiert werden!");
            }
        }

        public void MakeInvestment()
        {
            if (talkedToBankEmployee && investmentStrategy != null)
            {
                investmentStrategy.Invest(investmentMoney);
                Console.WriteLine($"Du hast {investmentMoney} in {investmentStrategy.getInfo()} investiert!");
            }
            else
            {
                Console.WriteLine("Bitte reden Sie zunächst mit ihrer Beraterin und wählen Sie ihre Investment Strategie!");
            }
        }

        public IInvestmentStrategy TalkToBankEmployee()
        {
            talkedToBankEmployee = true;
            List<dynamic> investmentList = new List<dynamic>() 
            { 
                new GoldInvestment(), 
                new CryptoInvestment(), 
                new StockMarketInvestment()
            };
            IInvestmentStrategy recommendedStrategy = investmentList[fancyAlgorithm()];
            Console.WriteLine($"Beraterin: Ich habe die Anlagestrategien überprüft und empfehle in {recommendedStrategy.getInfo()} zu investieren!");
            return recommendedStrategy;
        }

        public void SetInvestmentStrategy(IInvestmentStrategy strategy)
        {
            Console.WriteLine("Die Strategie wurde geändert");
            investmentStrategy = strategy;
        }

        private int fancyAlgorithm()
        {
            Random rnd = new Random();
            return rnd.Next(3);
        }
    }
}
