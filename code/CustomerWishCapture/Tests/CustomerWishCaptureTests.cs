
using Xunit;

public class CustomerWishCaptureTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new CustomerWishCaptureService();
        var result = service.Create(new CustomerWishCaptureRequest());
        Assert.NotNull(result);
    }
}
