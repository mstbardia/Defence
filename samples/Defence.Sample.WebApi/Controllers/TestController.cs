using Microsoft.AspNetCore.Mvc;

namespace Defence.Sample.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] UserCommand command)
    {
        return Ok("done");
    }

    [HttpPost]
    public IActionResult Post(UserCommand command)
    {
        return Ok("done");
    }
}