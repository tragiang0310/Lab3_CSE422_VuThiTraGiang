using Lab3_CSE422_VuThiTraGiang.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public class PremiumMember : Member, IPrintable, IMemberActions
    {
        public DateTime MembershipExpiry { get; set; }
        public int MaxBooksAllowed { get; set; }

        public PremiumMember(string memberID, string name, string email, DateTime membershipExpiry, int maxBooksAllowed)
        : base(memberID, name, email)
        {
            MembershipExpiry = membershipExpiry;
            MaxBooksAllowed = maxBooksAllowed;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Premium Member Information:");
            Console.WriteLine($"Membership Expiry: {MembershipExpiry}");
            Console.WriteLine($"Max Books Allowed: {MaxBooksAllowed}");
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Premium Member Information:");
            Console.WriteLine($"Membership Expiry: {MembershipExpiry}");
            Console.WriteLine($"Max Books Allowed: {MaxBooksAllowed}");
        }

        public override void BorrowBook(Book book)
        {
            // Premium members might have different borrowing rules (e.g., max books)
            if (book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                Console.WriteLine($"{Name} (Premium) borrowed {book.Title}.");
            }
            else
            {
                Console.WriteLine($"{book.Title} is currently unavailable.");
            }
        }

        public override void ReturnBook(Book book)
        {
            book.CopiesAvailable++;
            Console.WriteLine($"{Name} (Premium) returned {book.Title}.");
        }
    }
}
