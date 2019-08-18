using System.ComponentModel.DataAnnotations;

namespace LocalRoomApi.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}