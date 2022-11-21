using API.Models;

namespace API.Services
{
    public class Services
    {
        private readonly LandonContext _context;

        public Services(LandonContext context){
            _context = context;
        }

        public List<RoomEntity> getAll(){
            return _context.Rooms.ToList();
        }
    }
}