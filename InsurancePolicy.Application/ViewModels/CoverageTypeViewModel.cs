namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System.Collections.Generic;
    public class CoverageTypeViewModel
    {
        public IEnumerable<CoverageType> CoverageTypes { get; set; }
    }
}
