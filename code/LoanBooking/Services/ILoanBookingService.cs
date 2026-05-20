
public interface ILoanBookingService
{
    object Create(LoanBookingRequest request);
    object Get(string id);
}
