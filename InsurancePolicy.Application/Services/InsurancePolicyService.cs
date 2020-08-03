namespace InsurancePolicy.Application.Services
{
    using Interfaces;
    using ViewModels;
    using Domain.Interfaces;
    using InsurancePolicy.Domain.Models;

    public class InsurancePolicyService : BaseData, IInsurancePolicyService
    {
        public IRepository<InsurancePolicy> _insurancePolicyRepository;
        public InsurancePolicyService(IRepository<InsurancePolicy> insurancePolicyRepository)
        {
            _insurancePolicyRepository = insurancePolicyRepository;
        }

        public void CreateInsurancePolicy(InsurancePolicyViewModel insurancePolicyViewModel)
        {
            var insurancePolicy = this._mapper.Map<InsurancePolicyViewModel, InsurancePolicy>(insurancePolicyViewModel);
            _insurancePolicyRepository.Create(insurancePolicy);
        }

        public void DeleteInsurancePolicy(InsurancePolicyViewModel insurancePolicyViewModel)
        {
            var insurancePolicy = this._mapper.Map<InsurancePolicyViewModel, InsurancePolicy>(insurancePolicyViewModel);
            _insurancePolicyRepository.Delete(insurancePolicy);
        }

        public InsurancePolicyViewModel GetInsurancePolicies()
        {
            return new InsurancePolicyViewModel()
            {
                InsurancePolicies = _insurancePolicyRepository.GetAll()
            };
        }

        public void UpdateInsurancePolicy(InsurancePolicyViewModel insurancePolicyViewModel)
        {
            var insurancePolicy = this._mapper.Map<InsurancePolicyViewModel, InsurancePolicy>(insurancePolicyViewModel);
            _insurancePolicyRepository.Update(insurancePolicy);
        }
    }
}
