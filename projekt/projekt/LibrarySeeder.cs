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
            
              CategoryBook = new List<CategoryBook>()
              {
                  new CategoryBook()
                  {
                     
                      BookId = 1,
                     
                     
                  }
              
                  
              },
      
              Authors = new list<BookAuthor>()
              {
                new BookAuthor()
                {
                     
                      





    }
              },
                  

          },


            };
            return books;
        }

       
    }
}