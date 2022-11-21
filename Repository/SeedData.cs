using API.Models;
using API.Repository;

namespace API
{
    public  class SeedData : ISeedData
    
    {
        public async Task InitilizeAsync(IServiceProvider services)
        {
            await AddTestData( services.GetRequiredService<LandonContext>());
        }
        public async Task AddTestData(LandonContext context)     
        {
            if(context.Rooms.Any()){
                return;
            }
            context.Rooms.Add(new RoomEntity {
                Id = Guid.NewGuid(),
                Name = "Oxford Suite",
                Rate = 10231
            });
            context.Rooms.Add(new RoomEntity {
                Id = Guid.NewGuid(),
                Name = "Boston Suite",
                Rate = 13431
            });

            await context.SaveChangesAsync();
        }
    }
}