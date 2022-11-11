using DatabaseSelf.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSelf.Data;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        DbPath = "Data Source=LT037037;Initial Catalog=DatabaseSelf-Test;Integrated Security=true;TrustServerCertificate=Yes";
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(DbPath);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .ToTable("Posts", b => b.IsTemporal());
        modelBuilder.Entity<Blog>()
            .ToTable("Blogs", b => b.IsTemporal());
    }
}
