using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    public class Savings : Account
    {
        public float Rate { get; set; }
        public int MonthlyWithdrawls { get; set; }

        public Savings()
        {
            this.Balance = 50.00;
            MonthlyWithdrawls = 0;
            Rate = .0001f;
        }
    }
}
