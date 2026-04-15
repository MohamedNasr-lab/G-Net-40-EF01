using EfCore;
using Microsoft.EntityFrameworkCore;

internal class ApplicationDbContext : DbContext
{

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
    @"Server=DESKTOP-PS1NMJJ\SQLEXPRESS;Database=EFCore;Trusted_Connection=true;TrustServerCertificate=true");
    }
}