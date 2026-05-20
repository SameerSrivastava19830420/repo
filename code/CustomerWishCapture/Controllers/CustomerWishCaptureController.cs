
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/customerwishcapture")]
public class CustomerWishCaptureController : ControllerBase
{
    private readonly ICustomerWishCaptureService _service;

    public CustomerWishCaptureController(ICustomerWishCaptureService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] CustomerWishCaptureRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
