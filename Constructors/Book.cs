namespace Constructors
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) //Constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}