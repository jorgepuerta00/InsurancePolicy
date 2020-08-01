namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    public interface IInsurancePolicy
    {
        InsurancePolicyViewModel GetInsurancePolicies();
    }
}
