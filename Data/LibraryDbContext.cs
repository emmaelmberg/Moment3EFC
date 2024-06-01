using Microsoft.EntityFrameworkCore;
using Moment3EFC.Models;
namespace Moment3EFC.Data;

public class LibraryDbContext : DbContext {
public LibraryDbContext(DbContextOptions<LibraryDbContext>
options) : base(options) { }
public DbSet<AuthorModel> Authors { get; set; }
public DbSet<BookModel> Books { get; set; }
}