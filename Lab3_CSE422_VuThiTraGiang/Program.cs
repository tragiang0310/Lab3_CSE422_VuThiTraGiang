using Lab3_CSE422_VuThiTraGiang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //try
            //{ 
            //    Book book1 = new Book("978-0321765723", "The Lord of the Rings", "J.R.R. Tolkien", 1954, 5);
            //    book1.DisplayInfo();

            //    Book book2 = new Book("978-0141439518", "Pride and Prejudice", "Jane Austen", 1813, -5);
            //    book2.DisplayInfo();

            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}

            //Console.ReadKey();


            //Exercise 2
            //Member member1 = new Member("M001", "Giang", "giang_vu@eiu.edu.vn");
            //member1.DisplayInfo();

            //PremiumMember premiumMember = new PremiumMember("P001", "Cuong", "cuong_nguyen@eiu.edu.vn", DateTime.Now.AddDays(365), 10);
            //premiumMember.DisplayInfo();
            //Console.ReadKey();

            //Exercise 3
            //Member member1 = new Member("M001", "Giang", "giang_vu@eiu.edu.vn");
            //Book book1 = new Book("978-0321765723", "The Lord of the Rings", "J.R.R. Tolkien", 1954, 5);
            //Book book2 = new Book("978-0141439518", "Pride and Prejudice", "Jane Austen", 1813, 3);

            //BorrowTransaction borrowTransaction1 = new BorrowTransaction("T001", DateTime.Now, member1, book1);
            //borrowTransaction1.Execute();

            //ReturnTransaction returnTransaction1 = new ReturnTransaction("T002", DateTime.Now, member1, book1);
            //returnTransaction1.Execute();

            //BorrowTransaction borrowTransaction2 = new BorrowTransaction("T003", DateTime.Now, member1, book2);
            //borrowTransaction2.Execute();

            //BorrowTransaction borrowTransaction3 = new BorrowTransaction("T004", DateTime.Now, member1, book1);
            //borrowTransaction3.Execute();
            //Console.ReadKey();

            //Exercise 4
            //Member member1 = new Member("M001", "Giang", "giang_vu@eiu.edu.vn");
            //Book book1 = new Book("978-0321765723", "The Lord of the Rings", "J.R.R. Tolkien", 1954, 5);
            //Book book2 = new Book("978-0141439518", "Pride and Prejudice", "Jane Austen", 1813, 3);

            //List<Transaction> transactions = new List<Transaction>();

            //transactions.Add(new BorrowTransaction("T001", DateTime.Now, member1, book1));
            //transactions.Add(new ReturnTransaction("T002", DateTime.Now, member1, book1));
            //transactions.Add(new BorrowTransaction("T003", DateTime.Now, member1, book2));
            //transactions.Add(new BorrowTransaction("T004", DateTime.Now, member1, book1)); 
            //transactions.Add(new ReturnTransaction("T005", DateTime.Now, member1, book2)); 

            //foreach (Transaction transaction in transactions)
            //{
            //    transaction.Execute();
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            //Exercise 5

        }
    }
}
