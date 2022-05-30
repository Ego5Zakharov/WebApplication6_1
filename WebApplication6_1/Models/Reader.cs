using System.ComponentModel.DataAnnotations;

namespace WebApplication6_1.Models
{
    public class Reader
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ReaderTickets? readerTickets { get; set; }
    }
}
