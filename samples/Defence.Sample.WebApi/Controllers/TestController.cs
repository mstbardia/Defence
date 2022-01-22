using Microsoft.AspNetCore.Mvc;

namespace Defence.Sample.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] UserCommand command, [FromQuery]RoleCommand roleCommand)
    {
        var x = command;

        return Ok("done");
    }

    [HttpPost]
    public IActionResult Post(UserCommand command)
    {
        var x = command;

        return Ok("done");
    }
}