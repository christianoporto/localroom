using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalRoomApi.Models
{
    public class Subcategory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
