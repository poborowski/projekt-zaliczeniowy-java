namespace projekt.Entity
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual Author Author { get; set; }
    }
}
