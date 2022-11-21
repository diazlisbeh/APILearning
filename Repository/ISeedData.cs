using API.Models;

namespace API.Repository
{
    public interface ISeedData
    {
         
        public  Task InitilizeAsync(IServiceProvider services);
        public   Task AddTestData(LandonContext context);     
    }
}