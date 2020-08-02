namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;
    using InsurancePolicy.Domain.Models;

    public class InsurancePolicyService : IInsurancePolicyService
    {
        public IRepository<InsurancePolicy> _insurancePolicyRepository;
        public InsurancePolicyService(IRepository<InsurancePolicy> insurancePolicyRepository)
        {
            _insurancePolicyRepository = insurancePolicyRepository;
        }

        public void CreateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            _insurancePolicyRepository.Create(insurancePolicy);
        }

        public void DeleteInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            _insurancePolicyRepository.Delete(insurancePolicy);
        }

        public InsurancePolicyViewModel GetInsurancePolicies()
        {
            return new InsurancePolicyViewModel()
            {
                InsurancePolicies = _insurancePolicyRepository.GetAll()
            };
        }

        public void UpdateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            _insurancePolicyRepository.Update(insurancePolicy);
        }
    }
}
