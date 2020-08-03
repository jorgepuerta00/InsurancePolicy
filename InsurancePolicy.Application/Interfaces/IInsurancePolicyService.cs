namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;

    public interface IInsurancePolicyService
    {
        void CreateInsurancePolicy(InsurancePolicyViewModel insurancePolicy);
        void UpdateInsurancePolicy(InsurancePolicyViewModel insurancePolicy);
        InsurancePolicyViewModel GetInsurancePolicies();
        void DeleteInsurancePolicy(InsurancePolicyViewModel insurancePolicy);
    }
}
