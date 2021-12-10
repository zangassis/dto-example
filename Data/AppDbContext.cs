using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Seller>? Sellers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource = app.db; Cache=Shared");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Seller>().HasData(
            new Seller(Guid.NewGuid(), "John Smith", DateTime.UtcNow, "John@mail.com", "947 Heritage Road", 10),
                 new Seller(Guid.NewGuid(), "Violet Marshall", DateTime.UtcNow, "vmarshall@mail.com", "360 Bates Brothers Road", 10)
        );
    }
}