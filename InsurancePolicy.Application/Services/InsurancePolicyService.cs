namespace InsurancePolicy.Application.Services
{
    using Interfaces;
    using ViewModels;
    using Domain.Interfaces;
    using InsurancePolicy.Domain.Models;
    using System.Collections.Generic;

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

        public IEnumerable<InsurancePolicyViewModel> GetInsurancePolicies()
        {
            return this._mapper.Map<IEnumerable<InsurancePolicy>, IEnumerable<InsurancePolicyViewModel>>(_insurancePolicyRepository.GetAll());
        }

        public void UpdateInsurancePolicy(InsurancePolicyViewModel insurancePolicyViewModel)
        {
            var insurancePolicy = this._mapper.Map<InsurancePolicyViewModel, InsurancePolicy>(insurancePolicyViewModel);
            _insurancePolicyRepository.Update(insurancePolicy);
        }

        public bool ValidateInsurancePolicy(InsurancePolicyViewModel insurancePolicyViewModel, RiskTypeViewModel riskTypeViewModel)
        {
            return insurancePolicyViewModel.CoveragePercentage <= riskTypeViewModel.MaxCoverage;
        }
    }
}
