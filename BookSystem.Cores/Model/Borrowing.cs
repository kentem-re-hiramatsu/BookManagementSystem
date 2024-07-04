﻿using System;

namespace BookSystem.Cores.Model
{
    public class Borrowing
    {
        public bool IsLendable { get; set; }
        public DateTime? BorrowingTime { get; set; }
        public DateTime? DeadlineDateTime { get; set; }

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
                DeadlineDateTime = deadlineDateTime;
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

        /// <summary>
        /// 返却処理
        /// </summary>
        public void SetReturn()
        {
            if (!IsLendable)
            {
                IsLendable = true;
                BorrowingTime = null;
                DeadlineDateTime = null;
            }
            else
            {
                throw new Exception("貸出がされていません。");
            }
        }

        /// <summary>
        /// 貸出状況を〇×！で返す
        /// </summary>
        public string GetLendingStatusByshape()
        {
            if (IsLendable)
                return "〇";
            else if (DateTime.Now.Date > DeadlineDateTime.Value.Date)
                return "×!";
            else
                return "×";
        }

        /// <summary>
        /// 貸出状況を返す
        /// </summary>
        public string GetLendingStatus()
        {
            if (IsLendable)
                return "貸出可";
            else if (DateTime.Now.Date > DeadlineDateTime.Value.Date)
            {
                TimeSpan overDateTime = (TimeSpan)(DateTime.Now - DeadlineDateTime);
                return $"貸出中({overDateTime.TotalDays.ToString("F0")}日の期限超過)";
            }
            else
                return "貸出中";
        }
    }
}