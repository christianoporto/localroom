using System.ComponentModel.DataAnnotations;

namespace LocalRoomApi.Models
{
    //El nombre y la descripcion no son obligatorios
    //Si los campos estan vacios el nombre se verá así: session (#)
    public class CourseSection
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int SessionNumber { get; set; }
        public string Description { get; set; }
        public string Objective { get; set; }
    }
}
