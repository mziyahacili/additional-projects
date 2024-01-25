using Microsoft.EntityFrameworkCore;

namespace LINQ1.Services;

public interface IDataConnectionService
{
    public DbContextOptionsBuilder<T> Configure<T>(string connectionName) where T : DbContext;
}