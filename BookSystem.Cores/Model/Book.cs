﻿using BookSystem.Cores.Enum;

namespace BookSystem.Cores.Model
{
    public abstract class Book
    {
        public string Title { get; set; }
        public BookType Type { get; protected set; }
        public BookDetail Detail { get; set; }
        public Borrowing Borrowing { get; set; }

        public Book(string title, BookDetail detail)
        {
            Title = title;
            Detail = detail;
            Borrowing = new Borrowing();
        }
    }
}
