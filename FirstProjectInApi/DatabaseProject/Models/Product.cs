using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.Models
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
