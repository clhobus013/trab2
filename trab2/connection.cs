using Microsoft.EntityFrameworkCore;

public class Connection : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseNpgsql(Environment.GetEnvironmentVariable("DB_CONNECTION"));
    }
}