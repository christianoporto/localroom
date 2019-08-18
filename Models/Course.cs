using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalRoomApi.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Subtitle { get; set; }

        [Required]
        public string Description { get; set; }

        public string Prerequisites { get; set; }

        public string TargetAudience { get; set; }

        [Required]
        public double CourseDurationSeconds { get; set; }

        [Required]
        public string LenguegeIsoCode { get; set; }

        [Required]
        //NIVELES: 0 TODOS | 1 BASICO | 2 INTERMEDIO | 3 AVANZADO
        public int LevelValue { get; set; }

        public string CoverImageLink { get; set; }
        public string PromotionalVideoLink { get; set; }

        [Required]
        //0 GRATIS | 1 = 5USD | 2 = 10USD | 3 = 15USD .... | 40 = 200 USD
        public int PriceLevel { get; set; }

        public int SubcategoryId { get; set; }
        [ForeignKey("SubcategoryId")]
        public Subcategory Subcategory { get; set; }

        [Required]
        public int InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }

        public DateTime DateCreated { get; set; }

        //OPCIONAL: indica que el cursos debe cumplir con un intervalo de fechas
        //si hay un ciclo activo las activades de las lecciones tambien deben tener un ciclo de respuesta
        public int CourseCycleId { get; set; }
        [ForeignKey("CourseCycleId")]
        public CourseCycle CourseCycle { get; set; }
    }
}
