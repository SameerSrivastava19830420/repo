
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/customeronboarding")]
public class CustomerOnboardingController : ControllerBase
{
    private readonly ICustomerOnboardingService _service;

    public CustomerOnboardingController(ICustomerOnboardingService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] CustomerOnboardingRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
