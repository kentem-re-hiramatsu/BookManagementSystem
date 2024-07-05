using System;

namespace BookSystem.Cores.Model
{
    public class Borrowing
    {
        public User User { get; set; }
        public bool IsLendable { get; set; }
        public DateTime? BorrowingTime { get; set; }
        public DateTime? DeadlineDateTime { get; set; }

        public Borrowing()
        {
            IsLendable = true;
        }

        /// <summary>
        /// 貸出状況を返す
        /// </summary>
        public string GetLendingStatus()
        {
            if (IsLendable)
                return Consts.LOANABLE_MESSAGE;
            else if (DateTime.Now.Date > DeadlineDateTime.Value.Date)
            {
                TimeSpan overDateTime = (TimeSpan)(DateTime.Now - DeadlineDateTime);
                return $"貸出中({overDateTime.TotalDays.ToString("F0")}日の期限超過)";
            }
            else
                return Consts.ON_LOAN_MESSAGE;
        }
    }
}