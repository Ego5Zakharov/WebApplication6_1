using System.ComponentModel.DataAnnotations;

namespace WebApplication6_1.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string ?Title { get; set; }
        public int Price { get; set; }
    }
}
