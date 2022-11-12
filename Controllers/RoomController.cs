
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    [HttpGet(Name = nameof(GetRooms))]
    public IActionResult GetRooms()
    {
       
        throw new NotImplementedException();
    }
    
}