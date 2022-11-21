
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/")]
[ApiController]
[ApiVersion("1.0")]
public class RootController : ControllerBase
{
    [HttpGet (Name = nameof(GetRoot))]
    public IActionResult GetRoot()
    {
        var response = new {
            href = Url.Link(nameof(GetRoot),null),
            rooms = new {
                href = Url.Link(nameof(RoomController.GetRooms), null)
            },
            info= new{
                href = Url.Link(nameof(InfoController.GetInfo),null)
            }
        };
    

        return Ok(response);

    }

    
}