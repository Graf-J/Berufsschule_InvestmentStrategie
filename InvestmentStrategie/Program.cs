using System;

namespace InvestmentStrategie
{
    class Program
    {
        static void Main(string[] args)
        {
            Investment investment = new Investment(3000.00);
            IInvestmentStrategy recommendedStrategy;
            recommendedStrategy = investment.TalkToBankEmployee();
            investment.SetInvestmentStrategy(recommendedStrategy);
            investment.MakeInvestment();

            Console.ReadLine();
        }
    }
}
