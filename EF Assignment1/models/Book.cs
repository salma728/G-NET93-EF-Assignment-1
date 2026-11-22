
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreEFCore.Models
{
    [Table("BookInventory")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string ISBN { get; set; } = string.Empty;

        [Column("BookPrice", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublicationYear { get; set; }

        public bool IsInStock { get; set; }
    }
}
