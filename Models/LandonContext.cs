using Microsoft.EntityFrameworkCore;


namespace API.Models
{
    public class LandonContext : DbContext
    {

        public LandonContext(DbContextOptions options) : base(options){}

        public DbSet<RoomEntity> Rooms {get;set;}

        protected void OnModelCreating(ModelBuilder model){
            model.Entity<RoomEntity>().HasData(
                
            new RoomEntity {
                Id = Guid.NewGuid(),
                Name = "Oxford Suite",
                Rate = 10231
            },
            new RoomEntity {
                Id = Guid.NewGuid(),
                Name = "Boston Suite",
                Rate = 13431
            });
            
        }
    }


}