using System.ComponentModel.DataAnnotations;

namespace WebApplication6_1.Models
{
    public class ReaderTickets
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        List<Book> ?books { get; set; }
    }
}
