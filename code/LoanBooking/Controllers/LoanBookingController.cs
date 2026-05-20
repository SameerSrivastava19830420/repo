
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/loanbooking")]
public class LoanBookingController : ControllerBase
{
    private readonly ILoanBookingService _service;

    public LoanBookingController(ILoanBookingService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] LoanBookingRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
