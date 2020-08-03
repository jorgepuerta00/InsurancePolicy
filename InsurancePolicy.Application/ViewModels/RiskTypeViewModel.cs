namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System.Collections.Generic;
    public class RiskTypeViewModel
    {
        public int RiskTypeID { get; set; }
        public string RiskTypeCode { get; set; }
        public string RiskTypeName { get; set; }
        public int MaxCoverage { get; set; }
        public IEnumerable<RiskType> RiskTypes { get; set; }
    }
}
