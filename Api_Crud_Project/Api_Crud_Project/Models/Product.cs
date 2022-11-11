using System.ComponentModel.DataAnnotations;

namespace Api_Crud_Project.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ? ProductName { get; set; }

        [Required]
        public string ? ProductCode { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public bool IsDelete { get; set; }
    }
}
