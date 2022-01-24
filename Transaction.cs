using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Transaction
    {
        public int TransactionId { get; set; }
        public string ToAccount { get; set; }
        public string FromAccount { get; set; }
        public double Amount { get; set; }
        public double Fee { get; set; }
        public DateTime TransactionDate { get; set; }
        public string OriginatingTransaction { get; set; }

        public Transaction()
        {

        }

        public Transaction(string to, string from, double amount, double fee, string origin)
        {
            Random transactionIdGenerator = new Random();
            this.TransactionId = transactionIdGenerator.Next(1000000, 1000000000);
            this.ToAccount = to;
            this.FromAccount = from;
            this.Amount = amount;
            this.Fee = fee;
            this.OriginatingTransaction = origin;
            this.TransactionDate = DateTime.Now;
        }
    }
}
