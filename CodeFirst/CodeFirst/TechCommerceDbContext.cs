using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class TechCommerceDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Product> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=TechCommerceDb;Integrated Security=true;TrustServerCertificate=True;");
    }
}
