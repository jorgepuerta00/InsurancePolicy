using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class InsurancePolicyService : IInsurancePolicy
    {
        public IInsurancePolicyRepository _InsurancePolicyRepository;
        public InsurancePolicyService(IInsurancePolicyRepository InsurancePolicyRepository)
        {
            _InsurancePolicyRepository = InsurancePolicyRepository;
        }
        InsurancePolicyViewModel IInsurancePolicy.GetInsurancePolicies()
        {
            throw new NotImplementedException();
        }
    }
}
