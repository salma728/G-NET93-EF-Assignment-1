
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreEFCore.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Biography { get; set; } = string.Empty;

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
