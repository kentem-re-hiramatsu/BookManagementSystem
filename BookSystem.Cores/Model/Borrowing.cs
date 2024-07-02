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

        public void SetBorrowingProcess()
        {
            if (IsLendable)
            {
                IsLendable = false;
                BorrowingTime = DateTime.Now;
                BorrowingPeriod = DateTime.Now.AddDays(14);
            }
            else
            {
                throw new Exception("貸出されているため貸し出すことができません。");
            }
        }

        public void SetReturnProcess()
        {
            if (IsLendable)
            {
                IsLendable = true;
                BorrowingTime = null;
                BorrowingPeriod = null;
            }
            else
            {
                throw new Exception("貸出がされていません。");
            }
        }

        public string GetLendingStatusByshape()
        {
            if (IsLendable)
                return "〇";
            else if (BorrowingPeriod > BorrowingTime)
                return "×!";
            else
                return "×";
        }

        public string GetLendingStatus()
        {
            if (IsLendable)
                return "貸出可";
            else
                return "貸出中";
        }
    }
}