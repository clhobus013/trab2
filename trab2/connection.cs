using Microsoft.EntityFrameworkCore;

public class Connection : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseNpgsql(Environment.GetEnvironmentVariable("DB_CONNECTION"));
    }
}