using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalRoomApi.Models
{
    public class LessonDiscussion
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int DiscussionParentId { get; set; }
        [ForeignKey("DiscussionParentId")]
        public LessonDiscussion DiscussionParent { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public int LikesCounter { get; set; }

        [Required]
        public int DislikesCounter { get; set; }

        public string AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }
    }
}
