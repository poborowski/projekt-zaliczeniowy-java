using Microsoft.EntityFrameworkCore;

namespace projekt.Entity;

public class LibraryDbContext:DbContext
{
    private string Connection= @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;";
    public DbSet<Book>Books{ get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Book>().Property(P => P.Name).IsRequired();
        modelBuilder.Entity<User>().Property(P => P.Email).IsRequired();
        modelBuilder.Entity<Author>().Property(P => P.Name).IsRequired();

        modelBuilder.Entity<BookAuthor>().HasKey(ba => new {ba.BookId, ba.AuthorId});
        modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Book).WithMany(ba => ba.Authors).HasForeignKey(ba => ba.BookId);
        modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Author).WithMany(ba => ba.Books).HasForeignKey(ba => ba.AuthorId);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(Connection);
    }
    

}
