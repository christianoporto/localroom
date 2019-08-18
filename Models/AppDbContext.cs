using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocalRoomApi.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //modelBuilder.Entity<EventCalendarLog>().HasOne(l => l.Participant).WithMany(u => u.EventCalendarLogs).OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Participant>().HasOne(a => a.ContactOwner).WithOne().HasForeignKey<Participant>(b => b.ContactOwnerId).OnDelete(DeleteBehavior.Restrict);
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
