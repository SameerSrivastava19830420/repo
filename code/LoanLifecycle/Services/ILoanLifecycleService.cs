
public interface ILoanLifecycleService
{
    object Create(LoanLifecycleRequest request);
    object Get(string id);
}
