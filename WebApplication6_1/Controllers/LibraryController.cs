using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6_1.Models;
using WebApplication6_1.Services;

namespace WebApplication6_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        LibraryService _service;
        public LibraryController(LibraryService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return _service.GetAll();
        }
        
        [HttpGet("{id}")]
        public ActionResult<Book>GetById(int id)
        {
            var book = _service.GetById(id);
            if (book is not null)
            {
                return book;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Create(Book newBook)
        {
            var book = _service.Create(newBook);
            return CreatedAtAction(nameof(GetById), new { id = book!.Id }, book);
        }

        [HttpPut("{id}/UpdateBook")]
        public IActionResult UpdateBook(int id, string bookTitle,int bookPrice)
        {
            var bookToUpdate = _service.GetById(id);

            if(bookToUpdate is not null)
            {
                _service.UpdateBook(id, bookTitle,bookPrice);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _service.GetById(id);

            if (book is not null)
            {
                _service.DeleteById(id);
                return Ok();
            }

            else
            {
                return NotFound();
            }
        }

    }
}
