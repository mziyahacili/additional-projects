using CodeFirst;
using Microsoft.EntityFrameworkCore;


using TechCommerceDbContext context = new();


context.Categories.AddRange(new List<Category>()
{
    new() { Name = "Laptops" },
    new() { Name = "Smartphones" },
    new() { Name = "Tablets" },
    new() { Name = "Monitors" },
    new() { Name = "Keyboards" },
    new() { Name = "Mice" }
});

context.SaveChanges();

var res = context.Categories.Where(x => x.Id >= 1);

foreach(var item in res)
{
    Console.WriteLine(item.Name);
}








