namespace BookSystem.Cores.Model
{
    public class BookDetail
    {
        public int TargetAge { get; set; }
        public string Author { get; set; }
        public string OverView { get; set; }
        public bool IsLendable { get; set; }

        public BookDetail(int age, string author, string overView)
        {
            TargetAge = age;
            Author = author;
            OverView = overView;
            IsLendable = true;
        }
    }
}