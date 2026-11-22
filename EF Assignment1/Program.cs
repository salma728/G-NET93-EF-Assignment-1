
using BookStoreEFCore.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BookStoreContext();

try
{
    // Applies the existing migrations and creates the database if it does not exist.
    context.Database.Migrate();

    Console.WriteLine("Database created or updated successfully!");

    Console.WriteLine($"Books count: {context.Books.Count()}");
    Console.WriteLine($"Authors count: {context.Authors.Count()}");
    Console.WriteLine($"Categories count: {context.Categories.Count()}");
}
catch (Exception exception)
{
    Console.WriteLine("Database creation failed!");
    Console.WriteLine(exception.Message);
}

Console.ReadKey();
