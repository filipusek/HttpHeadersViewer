using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HeadersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var headers = Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString());
        return new JsonResult(headers);
    }
}