namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using System.Collections.Generic;

    public interface IInsurancePolicyService
    {
        void CreateInsurancePolicy(InsurancePolicyViewModel insurancePolicy);
        void UpdateInsurancePolicy(InsurancePolicyViewModel insurancePolicy);
        IEnumerable<InsurancePolicyViewModel> GetInsurancePolicies();
        void DeleteInsurancePolicy(InsurancePolicyViewModel insurancePolicy);
    }
}
