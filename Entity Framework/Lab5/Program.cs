using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Retrieve all products
var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// Find product by ID
var product = await context.Products.FindAsync(1);

Console.WriteLine($"Found: {product?.Name}");

// First product with price > 50000
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive: {expensive?.Name}");