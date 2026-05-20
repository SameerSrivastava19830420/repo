
using System;

public class PaymentPlanService : IPaymentPlanService
{
    private readonly PaymentPlanRepository _repo = new PaymentPlanRepository();

    public object Create(PaymentPlanRequest request)
    {
        // Validation
        if(request == null) throw new Exception("Invalid Request");

        // Business logic placeholder
        var entity = new PaymentPlanModel()
        {
            Id = Guid.NewGuid().ToString(),
            Status = "CREATED"
        };

        // DB Save
        _repo.Save(entity);

        // Event Publish (placeholder)
        Console.WriteLine("Event: PaymentPlanCreated");

        return entity;
    }

    public object Get(string id)
    {
        return new { Id = id, Status = "FETCHED" };
    }
}
