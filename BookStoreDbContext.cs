
using Microsoft.EntityFrameworkCore;

namespace Assignment_1_EFCore;

public class BookStoreContext : DbContext
{
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer(
            "Server=karimgoda;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
