namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    public interface IInsurancePolicyService
    {
        InsurancePolicyViewModel GetInsurancePolicies();
    }
}
