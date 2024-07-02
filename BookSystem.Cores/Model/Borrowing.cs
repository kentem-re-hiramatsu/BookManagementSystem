using System;

namespace BookSystem.Cores.Model
{
    public class Borrowing
    {
        public bool IsLendable { get; set; }
        public DateTime? BorrowingTime { get; set; }
        public DateTime? BorrowingPeriod { get; set; }

        public Borrowing()
        {
            IsLendable = true;
        }
    }
}