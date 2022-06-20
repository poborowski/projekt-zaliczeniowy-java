using System.Text.Json.Serialization;

namespace projekt.Entity
{
    public class Author
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
       
        public ICollection<BookAuthor> Books{ get; set; }
    }
}
