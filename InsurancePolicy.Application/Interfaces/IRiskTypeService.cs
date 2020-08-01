namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    public interface IRiskTypeService
    {
        RiskTypeViewModel GetRiskTypes();
    }
}
