using Microsoft.EntityFrameworkCore;
using WellnessRoomTracker.Domain;

namespace WellnessRoomTracker.Persistence
{
    public class WellnessRoomDbContext:DbContext
    { 

        public DbSet<WellnessRoomStatus> RoomHistries { get; set; }

        public DbSet<Person> Persons{get;set;}

        public DbSet<Schedule> Schedules{get;set;}
        
        public WellnessRoomDbContext(DbContextOptions<WellnessRoomDbContext> options    )
        :base(options )
        {
            
        }
    }
}