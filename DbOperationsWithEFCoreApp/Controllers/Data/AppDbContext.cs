using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Controllers.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}