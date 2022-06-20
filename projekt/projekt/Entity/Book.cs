namespace projekt.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Category> Categories { get; set; }
     

        public ICollection<BookAuthor> Authors { get; set; }
        internal list<Author> Author { get; set; }
    }
}
