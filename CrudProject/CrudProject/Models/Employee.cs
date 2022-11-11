using System.ComponentModel.DataAnnotations;

namespace CrudProject.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ? Name { get; set; }

        [Required]
        public string ? Address { get; set; }

        [Required]
        public DateTime DOB { get; set; }
    }
}
