namespace BookSystem.Cores.Model
{
    public class PictureBook : Book
    {
        private const string TYPE = "絵本";

        public PictureBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = TYPE;
        }
    }
}