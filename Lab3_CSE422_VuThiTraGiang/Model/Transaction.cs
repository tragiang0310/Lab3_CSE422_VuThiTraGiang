using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public abstract class Transaction
    {
        public string TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public Member Member { get; set; }
        public Transaction(string transactionID, DateTime transactionDate, Member member)
        {
            TransactionID = transactionID;
            TransactionDate = transactionDate;
            Member = member;
        }
        public abstract void Execute();
    }
}
