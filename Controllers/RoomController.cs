
using API.Models;
using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers;

[Route("/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    private IService _service;
    public RoomController (IService service){
        _service = service;
    }
    [HttpGet(Name = nameof(GetRooms))]
    public IActionResult GetRooms()
    {
      return Ok(_service.getAll()); 
    }

    
    
}
