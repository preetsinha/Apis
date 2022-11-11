using System.ComponentModel.DataAnnotations;

namespace Book_Api_Laibrary.Models
{
    public class BookLaibrary
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? title{ get; set; }

        [Required]
        public string? authorname { get; set; }

        [Required]
        public string? subject { get; set; }
    
       
        [Required]
        public string? bookno { get; set; }
    }
}
