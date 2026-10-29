
using BookStoreEFCore.Data;

using var context = new BookStoreContext();

if (context.Database.CanConnect())
{
    Console.WriteLine("Database connection successful!");

    Console.WriteLine($"Books count: {context.Books.Count()}");
    Console.WriteLine($"Authors count: {context.Authors.Count()}");
    Console.WriteLine($"Categories count: {context.Categories.Count()}");
}
else
{
    Console.WriteLine("Database connection failed!");
}

Console.ReadKey();
