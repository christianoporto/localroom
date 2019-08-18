using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalRoomApi.Models
{
    public class CourseLesson
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public string Objective { get; set; }

        public string VideoLink { get; set; }
        public int DurationSeconds { get; set; }


    }
}
