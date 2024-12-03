using Microsoft.EntityFrameworkCore;

public class Connection : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseNpgsql(Environment.getEnvironmentVariable("DB_CONNECTION"));
    }
}