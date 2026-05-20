
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/contractgeneration")]
public class ContractGenerationController : ControllerBase
{
    private readonly IContractGenerationService _service;

    public ContractGenerationController(IContractGenerationService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] ContractGenerationRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
