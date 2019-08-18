using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalRoomApi.Models
{
    public class CourseCycle
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public Course Course { get; set; }
    }
}
