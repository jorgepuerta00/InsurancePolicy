namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using Domain.Models;

    public interface IInsurancePolicyService
    {
        InsurancePolicyViewModel GetInsurancePolicies();
        void CreateInsurancePolicy(InsurancePolicy insurancePolicy);
        void UpdateInsurancePolicy(InsurancePolicy insurancePolicy);
        void DeleteInsurancePolicy(InsurancePolicy insurancePolicy);
    }
}
