
public interface IPaymentPlanService
{
    object Create(PaymentPlanRequest request);
    object Get(string id);
}
