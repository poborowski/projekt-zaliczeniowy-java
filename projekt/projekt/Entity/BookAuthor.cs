namespace projekt.Entity
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
