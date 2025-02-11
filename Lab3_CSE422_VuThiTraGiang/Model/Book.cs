using Lab3_CSE422_VuThiTraGiang.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    internal class Book : IPrintable
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private int year;
        private int copiesAvailable;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Year cannot be less than 0");
                year = value;
            }
        }

        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("CopiesAvailable cannot be less than 0");
                copiesAvailable = value;
            }
        }
        public Book(string isbn, string title, string author, int year, int copiesAvailable)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;
            CopiesAvailable = copiesAvailable;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }

        public void PrintDetails()
        {
            Console.WriteLine("Book Information:");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }
    }
}
