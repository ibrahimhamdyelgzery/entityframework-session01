
namespace Assignment_1_EFCore;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Pages { get; set; }
    public int PublicationYear { get; set; }
    public bool InStock { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
