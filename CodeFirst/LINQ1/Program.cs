using TechDataLayer;

using LINQ1.Services;
using Microsoft.Extensions.Configuration;


IConfigurationBuilder builder = new ConfigurationBuilder();
IDataConnectionService dataConnectionService = new DataConnectionService(builder);

var optionsBuilder = dataConnectionService.Configure<TechCommerceDbContext>("Default");

using var dbContext = new TechCommerceDbContext(optionsBuilder.Options);

var categories = dbContext.Categories;

foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}