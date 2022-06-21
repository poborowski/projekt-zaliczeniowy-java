using System.Text.Json.Serialization;

namespace projekt.Entity
{
    public class Category
    {
        public int Id { get; set; }
   
        public string Description { get; set; }
       public string Name { get; set; }

        public virtual ICollection<CategoryBook> Books { get; set; }
    }
}
