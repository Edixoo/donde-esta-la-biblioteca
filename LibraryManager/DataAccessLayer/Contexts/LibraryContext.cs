using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Contexts;

public class LibraryContext : DbContext
{
    public readonly DbContextOptionsBuilder _context;
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne<Author>(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);


        modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithOne(a => a.Author)
            .HasForeignKey(b => b.Id);
    }

}