
using Xunit;

public class LoanBookingTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new LoanBookingService();
        var result = service.Create(new LoanBookingRequest());
        Assert.NotNull(result);
    }
}
