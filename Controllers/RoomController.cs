
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    private SeedData _repository;
    public RoomController ( SeedData repository){
        _repository = repository;
    }
    [HttpGet(Name = nameof(GetRooms))]
    public IActionResult GetRooms()
    {
        throw new NotImplementedException();
        // return _repository.InitilizeAsync();
       
    }

    
    
}
