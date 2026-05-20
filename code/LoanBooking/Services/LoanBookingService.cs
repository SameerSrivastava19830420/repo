
using System;

public class LoanBookingService : ILoanBookingService
{
    private readonly LoanBookingRepository _repo = new LoanBookingRepository();

    public object Create(LoanBookingRequest request)
    {
        // Validation
        if(request == null) throw new Exception("Invalid Request");

        // Business logic placeholder
        var entity = new LoanBookingModel()
        {
            Id = Guid.NewGuid().ToString(),
            Status = "CREATED"
        };

        // DB Save
        _repo.Save(entity);

        // Event Publish (placeholder)
        Console.WriteLine("Event: LoanBookingCreated");

        return entity;
    }

    public object Get(string id)
    {
        return new { Id = id, Status = "FETCHED" };
    }
}
