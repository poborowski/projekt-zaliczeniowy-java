using projekt.Entity;

namespace projekt
{
    public class LibrarySeeder
    {
        private readonly LibraryDbContext _context;
        public LibrarySeeder(LibraryDbContext libraryDbCo)
        {
            _context = libraryDbCo;
        }
        public void Seed()
        {
            if (_context.Database.CanConnect())
            {
      
                if (!_context.Books.Any())
                {
                    var Books = GetBooks();
                    _context.Books.AddRange(Books);
                    _context.SaveChanges();
                }

            }
        }


        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>()
          {

          new Book()
          {
              Name = "W pustyni i w puszczy",
              Description = "Przygoda w afryce",
            
              Categories = new List<Category>()
              {
                  new Category()
                  {

                      Name = "przygodowe",
                      Description = "Przgody",
                  }
              
                  
              },
      
              Authors = new list<BookAuthor>()
              {
                new BookAuthor()
                {
                    Name = "Bartek",
                    BookId = 1,
            
                    AuthorId = 1,
                 
     

    }
              },
                  

          },


            };
            return books;
        }

       
    }
}