﻿namespace BookSystem.Cores
{
    public static class Consts
    {
        public const string ERROR_MESSAGE = "エラー";

        public const string OVER_LOAN_PEROD_ERROR_MESSAGE = "貸出期限は２週間以内です";
        public const string ON_LOAN_ERROR_MESSAGE = "貸出されているため貸し出すことができません";
        public const string NOT_LOAN_ERROR_MESSAGE = "貸出がされていません";

        public const string LOANABLE_MESSAGE = "貸出可";
        public const string ON_LOAN_MESSAGE = "貸出中";

        public const string LOANABLE_CIRCLE_MESSAGE = "〇";
        public const string ON_LOAN_CROSS_MESSAGE = "×";
        public const string OVER_LOAN_PEROD_CIRCLE_MESSAGE = "×!";
    }
}