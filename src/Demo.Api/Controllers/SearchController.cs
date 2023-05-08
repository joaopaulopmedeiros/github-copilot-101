namespace Demo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
    /// <summary>
    /// Binary Search O(log n)
    /// </summary>
    /// <param name="request"></param>
    /// <param name="service"></param>
    /// <returns>Index of item</returns>
    [HttpGet("Binary")]
    public IActionResult BinarySearch
    (
        [FromServices] BinarySearchService service,
        [FromQuery] SearchRequest request
    )
    {
        var result = service.Run(request.Array, request.Value);
        return Ok(result);
    }

    /// <summary>
    /// Linear Search O(n)
    /// </summary>
    /// <param name="request"></param>
    /// <param name="service"></param>  
    /// <returns></returns>
    [HttpGet("Linear")]
    public IActionResult LinearSearch
    (
        [FromServices] LinearSearchService service, 
        [FromQuery] SearchRequest request
    )
    {
        var result = service.Run(request.Array, request.Value);
        return Ok(result);
    }
}
