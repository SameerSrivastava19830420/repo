
using Xunit;

public class LoanClosureTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new LoanClosureService();
        var result = service.Create(new LoanClosureRequest());
        Assert.NotNull(result);
    }
}
