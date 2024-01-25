using TechDataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LINQ1.Services;


public class DataConnectionService : IDataConnectionService
{
    
    private readonly IConfigurationBuilder _builder;

    public DataConnectionService(IConfigurationBuilder builder)
    {
        _builder = builder;
    }

    public DbContextOptionsBuilder<T> Configure<T>(string connectionName) where T : DbContext
    {
        _builder.AddJsonFile("appsettings.json");
        var config = _builder.Build();
        var connectionString = config.GetConnectionString(connectionName);

        return new DbContextOptionsBuilder<T>().UseSqlServer(connectionString);
    }
}