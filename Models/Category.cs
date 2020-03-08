using System.ComponentModel.DataAnnotations;

namespace exemplo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [MaxLength(60, ErrorMessage = "The lenght of this field must be between 3 and 60")]
        [MinLength(3, ErrorMessage = "The lenght of this field must be between 3 and 60")]
        public string Title { get; set; }
    }
}