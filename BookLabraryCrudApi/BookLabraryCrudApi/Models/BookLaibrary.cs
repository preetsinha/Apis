using System.ComponentModel.DataAnnotations;

namespace BookLabraryCrudApi.Models
{
    public class BookLaibrary
    {
        [Key]
        int Id { get; set; }

        [Required]
        string? title { get; set; }
        [Required]
        string? subject { get; set; }
        [Required]
        string? authorname { get; set; }
        [Required]
        int bookno { get; set; }
    }
}
