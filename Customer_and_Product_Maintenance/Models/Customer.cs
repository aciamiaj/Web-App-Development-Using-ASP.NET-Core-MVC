using System.ComponentModel.DataAnnotations;
using Unipluss.Sign.Common.Validation;

namespace Lab3.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string? CustomerName { get; set; }
        [Required]
        [EmailAddress]
        public string? CustomerEmail { get; set; }
        public string? Phone { get; set; }
    }
}
