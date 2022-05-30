using Microsoft.EntityFrameworkCore;
using WebApplication6_1.Data;
using WebApplication6_1.Models;

namespace WebApplication6_1.Services
{
    public class LibraryService
    {
        private readonly BookContext _context;

        public LibraryService(BookContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }
        public Book? GetById(int id)
        {
            return _context.Books.SingleOrDefault(b => b.Id == id);
        }

        public Book?Create(Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook;
        }

        public void DeleteById(int id)
        {
            var bookToDelete = _context.Books.Find(id);
            if(bookToDelete is not null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateBook(int bookId, string bookTitle, int bookPrice)
        {
            var bookToUpdate = _context.Books.Find(bookId);

            if( bookToUpdate is not null)
            {
                bookToUpdate.Title = bookTitle;
                bookToUpdate.Price = bookPrice;
                _context.SaveChanges();
            }

            else
            {
                throw new InvalidOperationException("Книга не найдена!");
            }

        }
    }
}
