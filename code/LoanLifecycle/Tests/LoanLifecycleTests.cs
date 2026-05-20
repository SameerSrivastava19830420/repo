
using Xunit;

public class LoanLifecycleTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new LoanLifecycleService();
        var result = service.Create(new LoanLifecycleRequest());
        Assert.NotNull(result);
    }
}
