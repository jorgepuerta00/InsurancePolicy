using System;

namespace InsurancePolicy.Domain.Models
{
    public class InsurancePolicy
    {
        public int InsurancePolicyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CoverageTypeID { get; set; }
        public int CoveragePercentage { get; set; }
        public int CoverageTimeElapsed { get; set; }
        public DateTime Startdate { get; set; }
        public float TotalCost { get; set; }
        public int RiskTypeID { get; set; }
    }
}
