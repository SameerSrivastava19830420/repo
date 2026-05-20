
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/loanlifecycle")]
public class LoanLifecycleController : ControllerBase
{
    private readonly ILoanLifecycleService _service;

    public LoanLifecycleController(ILoanLifecycleService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] LoanLifecycleRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
