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

        public void SetBorrowingProcess(DateTime deadlineDateTime)
        {
            if (IsLendable)
            {
                IsLendable = false;
                BorrowingTime = DateTime.Now;

                if (DateTime.Now.AddDays(15) > deadlineDateTime)
                    BorrowingPeriod = deadlineDateTime;
                else
                    throw new Exception("貸出期限は２週間以内です。");
            }
            else
            {
                throw new Exception("貸出されているため貸し出すことができません。");
            }
        }

        public void SetReturnProcess()
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