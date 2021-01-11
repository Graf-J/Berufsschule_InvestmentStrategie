using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentStrategie
{
    interface IInvestmentStrategy
    {
        public void Invest(double investedMoney);
        public string getInfo();
    }
}
