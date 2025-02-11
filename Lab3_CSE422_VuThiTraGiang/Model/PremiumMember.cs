using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    internal class PremiumMember : Member
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
    }
}
