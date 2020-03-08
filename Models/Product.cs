using System.ComponentModel.DataAnnotations;

namespace exemplo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "The lenght of this field must be between 3 and 60")]
        [MinLength(3, ErrorMessage = "The lenght of this field must be between 3 and 60")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "The lenght of this field must be smaller than 1024")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "The lenght of this field must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "The lenght of this field must be greater than 0")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}