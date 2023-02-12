using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Product
    {
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public decimal? Price { get; set; }    
    }
}
