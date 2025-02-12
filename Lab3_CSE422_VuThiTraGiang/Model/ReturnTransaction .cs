using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }

        public ReturnTransaction(string transactionID, DateTime transactionDate, Member member, Book bookReturned)
            : base(transactionID, transactionDate, member)
        {
            BookReturned = bookReturned;
        }

        public override void Execute()
        {

            BookReturned.CopiesAvailable++;
                Console.WriteLine($"{Member.Name} returned {BookReturned.Title} (ID: {BookReturned.ISBN}) on {TransactionDate}. Transaction ID: {TransactionID}");
            
        }
    }
}
