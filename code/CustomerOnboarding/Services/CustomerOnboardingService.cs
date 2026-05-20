
using System;

public class CustomerOnboardingService : ICustomerOnboardingService
{
    private readonly CustomerOnboardingRepository _repo = new CustomerOnboardingRepository();

    public object Create(CustomerOnboardingRequest request)
    {
        // Validation
        if(request == null) throw new Exception("Invalid Request");

        // Business logic placeholder
        var entity = new CustomerOnboardingModel()
        {
            Id = Guid.NewGuid().ToString(),
            Status = "CREATED"
        };

        // DB Save
        _repo.Save(entity);

        // Event Publish (placeholder)
        Console.WriteLine("Event: CustomerOnboardingCreated");

        return entity;
    }

    public object Get(string id)
    {
        return new { Id = id, Status = "FETCHED" };
    }
}
