
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/paymentplan")]
public class PaymentPlanController : ControllerBase
{
    private readonly IPaymentPlanService _service;

    public PaymentPlanController(IPaymentPlanService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] PaymentPlanRequest request)
    {
        return Ok(_service.Create(request));
    }

    [HttpGet("get/{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_service.Get(id));
    }
}
