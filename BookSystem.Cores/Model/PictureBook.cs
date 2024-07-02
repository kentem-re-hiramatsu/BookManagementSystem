namespace BookSystem.Cores.Model
{
    public class PictureBook : Book
    {
        public PictureBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = "絵本";
            Title = title;
            Detail = detail;
        }
    }
}
