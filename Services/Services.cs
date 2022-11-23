using API.Models;

namespace API.Services
{
    public class Service : IService
    {
        private readonly LandonContext _context;

        public Service(LandonContext context){
            _context = context;
        }

        public List<RoomEntity> getAll(){
            return _context.Rooms.ToList();
        }
    }
}