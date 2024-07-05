using System;

namespace BookSystem.Cores.Model
{
    public class Borrowing
    {
        public User User { get; set; }
        public bool IsLendable { get; set; }
        public DateTime? BorrowingDateTime { get; set; }
        public DateTime? DeadlineDateTime { get; set; }

        public Borrowing()
        {
            IsLendable = true;
        }
    }
}