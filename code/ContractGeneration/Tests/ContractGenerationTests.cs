
using Xunit;

public class ContractGenerationTests
{
    [Fact]
    public void CreateTest()
    {
        var service = new ContractGenerationService();
        var result = service.Create(new ContractGenerationRequest());
        Assert.NotNull(result);
    }
}
