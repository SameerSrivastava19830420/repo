
public interface IContractGenerationService
{
    object Create(ContractGenerationRequest request);
    object Get(string id);
}
