
using System;

public class LoanLifecycleService : ILoanLifecycleService
{
    private readonly LoanLifecycleRepository _repo = new LoanLifecycleRepository();

    public object Create(LoanLifecycleRequest request)
    {
        // Validation
        if(request == null) throw new Exception("Invalid Request");

        // Business logic placeholder
        var entity = new LoanLifecycleModel()
        {
            Id = Guid.NewGuid().ToString(),
            Status = "CREATED"
        };

        // DB Save
        _repo.Save(entity);

        // Event Publish (placeholder)
        Console.WriteLine("Event: LoanLifecycleCreated");

        return entity;
    }

    public object Get(string id)
    {
        return new { Id = id, Status = "FETCHED" };
    }
}
