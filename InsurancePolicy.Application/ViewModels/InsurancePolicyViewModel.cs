namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System;
    using System.Collections.Generic;
    public class InsurancePolicyViewModel
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
