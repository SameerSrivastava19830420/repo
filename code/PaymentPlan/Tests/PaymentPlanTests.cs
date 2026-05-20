
using Xunit;

public class PaymentPlanTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new PaymentPlanService();
        var result = service.Create(new PaymentPlanRequest());
        Assert.NotNull(result);
    }
}
