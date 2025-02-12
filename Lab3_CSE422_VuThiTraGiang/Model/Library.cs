using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public class Library
    {
        //properties
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        //Parameterless Constructor
        public Library()
        {
            LibraryName = "Default Library";
            Books = new List<Book>();
            Members = new List<Member>();
        }

        //Parameterized Constructor
        public Library(string libraryName, List<Book> initialBooks)
        {
            LibraryName = libraryName;
            Books = new List<Book>(initialBooks);
            Members = new List<Member>();
        }

        //Copy Constructor
        public Library(Library newLibrary)
        {
            LibraryName = newLibrary.LibraryName;
            Books = new List<Book>();

            foreach (Book book in newLibrary.Books)
            {
                Books.Add(new Book(book.ISBN, book.Title, book.Author, book.Year, book.CopiesAvailable));
            }

            Members = new List<Member>();
            foreach (Member member in newLibrary.Members)
            {
                Members.Add(new Member(member.MemberID, member.Name, member.Email));
            }
        }

        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"Library Name: {LibraryName}");
            Console.WriteLine($"Number of Books: {Books.Count}");
            Console.WriteLine($"Number of Members: {Members.Count}");
            Console.WriteLine();

            Console.WriteLine("Books:");
            foreach (Book book in Books)
            {
                book.PrintDetails();
                Console.WriteLine();
            }

            Console.WriteLine("Members:");
            foreach (Member member in Members)
            {
                member.PrintDetails();
                Console.WriteLine();
            }

        }
    }
}
