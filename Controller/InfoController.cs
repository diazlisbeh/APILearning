using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.Extensions.Options;

namespace API.Controllers;

[Route("/[controller]")]
[ApiController]
public class InfoController : ControllerBase{

    private readonly HotelInfo _hotelInfo;

    public InfoController( IOptions<HotelInfo> a ){
        _hotelInfo = a.Value;
    }
    [HttpGet(Name=nameof(GetInfo))]
    [ProducesResponseType(200)]
    public ActionResult<HotelInfo> GetInfo(){
       _hotelInfo.Href = Url.Link(nameof(GetInfo),null); 
       return _hotelInfo;
    }
}