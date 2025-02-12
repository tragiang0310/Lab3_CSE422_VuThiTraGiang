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
            //    Book book1 = new Book("978-0321765723", "Elements of Reusable Object-Oriented Software", "Erich Gamma", 1954, 5);
            //    book1.DisplayInfo();

            //    Book book2 = new Book("978-0141439518", "Head First Design Patterns", "Jane Austen", 1813, -5);
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
            //Book book1 = new Book("978-0321765723", "Elements of Reusable Object-Oriented Software", "Erich Gamma", 1954, 5);
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
            //Book book1 = new Book("978-0321765723", "Elements of Reusable Object-Oriented Software", "Erich Gamma", 1954, 5);
            //Book book2 = new Book("978-0141439518", "Head First Design Patterns", "Jane Austen", 1813, 3);

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
            //Book book1 = new Book("978-0321765723", "Elements of Reusable Object-Oriented Software", "Erich Gamma", 1954, 5);
            //Member member1 = new Member("M001", "Giang", "giang_vu@eiu.edu.vn");
            //PremiumMember premiumMember1 = new PremiumMember("P001", "Bob", "bob@example.com", DateTime.Now.AddDays(365), 3);

            //book1.PrintDetails();
            //Console.WriteLine();
            //member1.PrintDetails();
            //Console.WriteLine();
            //premiumMember1.PrintDetails();
            //Console.WriteLine();

            //member1.BorrowBook(book1);
            //book1.PrintDetails();
            //Console.WriteLine();

            //premiumMember1.ReturnBook(book1);
            //book1.PrintDetails();
            //Console.WriteLine();

            //Console.ReadKey();

            //Exercise 6
            //List<Book> initialBooks = new List<Book>()
            //{
            //    new Book("978-0321765723", "Elements of Reusable Object-Oriented Software", "Erich Gamma", 1954, 5),
            //    new Book("978-0141439518", "Head First Design Patterns", "Jane Austen", 1813, 10)
            //};


            //Library library1 = new Library(); 
            //library1.DisplayLibraryInfo();

            //Library library2 = new Library("City Library", initialBooks);
            //library2.DisplayLibraryInfo();

            //Library library3 = new Library(library2)
            //{
            //    LibraryName = "New City Library"
            //};
            //library3.DisplayLibraryInfo();

            //library2.DisplayLibraryInfo();


            //library2.Members.Add(new Member("M001", "Giang", "giang_vu@eiu.edu.vn"));
            //library2.DisplayLibraryInfo();

            //Console.ReadKey();

            //exercise 7
            //NotificationService notiService = new NotificationService();
            //AdvancedNotificationService advancedService = new AdvancedNotificationService();

            //notiService.SendNotification("Hello!");
            //notiService.SendNotification("Please join the group CSE422", "Giang");
            //notiService.SendNotification("Update assignment", new List<string> { "Giang", "Minh", "Ngoc" });
            //Console.WriteLine();

            //advancedService.SendNotification("Hello!");
            //advancedService.SendNotification("Please join the group CSE422", "John");
            //advancedService.SendNotification("Update assignment", new List<string> { "Giang", "Minh", "Ngoc" });

            //Console.ReadKey();

            //Exercise 8
            //Member member = new Member("M001", "Giang", "giang_vu@eiu.edu.vn");

            //LibraryCard card = new LibraryCard("12345", member);

            //card.DisplayCardInfo();

            //card.RenewCard();

            //card.DisplayCardInfo();

            //Console.ReadKey();


            //Exercise 9


        }
    }
}
