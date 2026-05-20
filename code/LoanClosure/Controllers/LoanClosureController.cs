
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/loanclosure")]
public class LoanClosureController : ControllerBase
{
    private readonly ILoanClosureService _service;

    public LoanClosureController(ILoanClosureService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] LoanClosureRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
