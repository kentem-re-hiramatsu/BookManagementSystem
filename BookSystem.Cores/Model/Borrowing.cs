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

        public void SetBorrowing(DateTime deadlineDateTime)
        {
            if (IsLendable && DateTime.Now.AddDays(14) > deadlineDateTime)
            {
                IsLendable = false;
                BorrowingTime = DateTime.Now;
                BorrowingPeriod = deadlineDateTime;
            }
            else if (deadlineDateTime >= DateTime.Now.AddDays(14))
            {
                throw new Exception("貸出期限は２週間以内です。");
            }
            else
            {
                throw new Exception("貸出されているため貸し出すことができません。");
            }
        }

        public void SetReturn()
        {
            if (!IsLendable)
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
            else if (DateTime.Now > BorrowingPeriod)
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