using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private static readonly string[] Items = new[]
    {
        "mars", "earth"
    };
    
    [HttpGet]
    public IActionResult Get() => Ok(Items);
}