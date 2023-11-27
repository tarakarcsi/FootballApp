using Microsoft.EntityFrameworkCore;

namespace API;

public class DataContext : DbContext
{
public DbSet<AppUser> Users { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }

}
