namespace projekt.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<CategoryBook> CategoryBook { get; set; }
      
     
        public virtual ICollection<BookAuthor> Authors { get; set; }
       
    }
}
