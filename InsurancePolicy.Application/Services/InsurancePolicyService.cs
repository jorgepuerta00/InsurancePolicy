namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class InsurancePolicyService : IInsurancePolicyService
    {
        public IInsurancePolicyRepository _insurancePolicyRepository;
        public InsurancePolicyService(IInsurancePolicyRepository insurancePolicyRepository)
        {
            _insurancePolicyRepository = insurancePolicyRepository;
        }
        public InsurancePolicyViewModel GetInsurancePolicies()
        {
            return new InsurancePolicyViewModel()
            {
                InsurancePolicies = _insurancePolicyRepository.GetInsurancePolicies()
            };
        }
    }
}
