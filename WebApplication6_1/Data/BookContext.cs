using Microsoft.EntityFrameworkCore;
using WebApplication6_1.Models;

namespace WebApplication6_1.Data
{
    public class BookContext :DbContext
    {
        public BookContext(DbContextOptions<BookContext>options):base(options)
        {

        }
        public DbSet <Book> Books => Set<Book>();
        public DbSet<Reader> Readers => Set<Reader>();
        public DbSet<ReaderTickets> ReadersTickets => Set<ReaderTickets>();

    } 
}
