
public interface ILoanClosureService
{
    object Create(LoanClosureRequest request);
    object Get(string id);
}
