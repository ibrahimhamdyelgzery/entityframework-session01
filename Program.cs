using Microsoft.EntityFrameworkCore;

namespace Assignment_1_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookStoreContext();

            context.Database.Migrate();
            Console.WriteLine("Database 'ReadMoreBooksDB' created successfully.");

            Console.WriteLine("\nTables created:");
            foreach (var entityType in context.Model.GetEntityTypes())
            {
                Console.WriteLine($" * {entityType.GetTableName()}");
            }
        }
    }
}