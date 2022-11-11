using System.ComponentModel.DataAnnotations;

namespace PersonsApi
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string firstname { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public int  age { get; set; }
        [Required]
        public string city { get; set; }



    }
}
