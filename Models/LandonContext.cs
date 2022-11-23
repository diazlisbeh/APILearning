using Microsoft.EntityFrameworkCore;


namespace API.Models
{
    public class LandonContext : DbContext
    {

        public LandonContext(DbContextOptions options) : base(options){}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            // optionsBuilder.UseInMemoryDatabase("landon");
        // }

        public DbSet<RoomEntity> Rooms {get;set;}
            List<RoomEntity> list = new List<RoomEntity>(){
            new RoomEntity {
                Id = Guid.NewGuid(),
                Name = "Oxford Suite",
                Rate = 10231
            },
            new RoomEntity {
                Id = Guid.NewGuid(),
                Name = "Boston Suite",
                Rate = 13431
            }
            };

        protected void OnModelCreating(ModelBuilder model){
            
            model.Entity<RoomEntity>(room => {
                room.HasData(list);
                
            });
            
            
            
            
            
        }
    }


}