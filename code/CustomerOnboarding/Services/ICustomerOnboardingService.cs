
public interface ICustomerOnboardingService
{
    object Create(CustomerOnboardingRequest request);
    object Get(string id);
}
