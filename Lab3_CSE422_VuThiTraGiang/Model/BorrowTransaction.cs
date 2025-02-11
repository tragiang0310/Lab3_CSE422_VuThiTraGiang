using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    internal class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }

        public BorrowTransaction(string transactionID, DateTime transactionDate, Member member, Book bookBorrowed)
        : base(transactionID, transactionDate, member)
        {
            BookBorrowed = bookBorrowed;
        }

        public override void Execute()
        {
            if (BookBorrowed.CopiesAvailable > 0)
            {
                BookBorrowed.CopiesAvailable --;
                Console.WriteLine($"{Member.Name} borrowed {BookBorrowed.Title} (ID: {BookBorrowed.ISBN}) on {TransactionDate}. Transaction ID: {TransactionID}");
            }
            else
            {
                Console.WriteLine($"{BookBorrowed.Title} is currently unavailable.");
            }
        }
    }
}
