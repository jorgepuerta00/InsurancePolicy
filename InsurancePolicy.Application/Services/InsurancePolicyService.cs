namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class InsurancePolicyService : IInsurancePolicy
    {
        public IInsurancePolicyRepository _insurancePolicyRepository;
        public InsurancePolicyService(IInsurancePolicyRepository insurancePolicyRepository)
        {
            _insurancePolicyRepository = insurancePolicyRepository;
        }
        InsurancePolicyViewModel IInsurancePolicy.GetInsurancePolicies()
        {
            return new InsurancePolicyViewModel()
            {
                InsurancePolicies = _insurancePolicyRepository.GetInsurancePolicies()
            };
        }
    }
}
