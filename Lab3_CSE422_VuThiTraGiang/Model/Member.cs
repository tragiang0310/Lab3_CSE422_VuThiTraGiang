using Lab3_CSE422_VuThiTraGiang.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public class Member : IPrintable, IMemberActions
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Member(string memberID, string name, string email)
        {
            MemberID = memberID;
            Name = name;
            Email = email;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Member Information:");
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine("Member Information:");
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }

        public virtual void BorrowBook(Book book)
        {
            if (book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                Console.WriteLine($"{Name} borrowed {book.Title}.");
            }
            else
            {
                Console.WriteLine($"{book.Title} is currently unavailable.");
            }
        }

        public virtual void ReturnBook(Book book)
        {
            book.CopiesAvailable++;
            Console.WriteLine($"{Name} returned {book.Title}.");
        }
    }
}
