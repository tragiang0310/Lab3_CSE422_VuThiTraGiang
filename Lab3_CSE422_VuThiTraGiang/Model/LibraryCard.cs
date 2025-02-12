using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public class LibraryCard
    {
        public string CardNumber { get; }

        public Member Owner { get; set; }

        public DateTime IssueDate { get; private set; }

        public LibraryCard(string cardNumber, Member owner)
        {
            CardNumber = cardNumber;
            Owner = owner;
            IssueDate = DateTime.Now;
        }

        public void RenewCard()
        {
            IssueDate = DateTime.Now;
            Console.WriteLine($"Card {CardNumber} renewed. New Issue Date: {IssueDate}");
        }


        public void DisplayCardInfo()
        {
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Owner: {Owner.Name}");
            Console.WriteLine($"Issue Date: {IssueDate}");
        }
    }
}
