namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System.Collections.Generic;
    public class InsurancePolicyViewModel
    {
        public IEnumerable<InsurancePolicy> InsurancePolicies { get; set; }
    }
}
