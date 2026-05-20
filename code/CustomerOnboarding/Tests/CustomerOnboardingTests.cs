
using Xunit;

public class CustomerOnboardingTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new CustomerOnboardingService();
        var result = service.Create(new CustomerOnboardingRequest());
        Assert.NotNull(result);
    }
}
