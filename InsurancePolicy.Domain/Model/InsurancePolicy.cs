﻿namespace InsurancePolicy.Domain.Model
{
    using System;
    public class InsurancePolicy
    {
        public int InsurancePolicyID { get; set; }
        public string Name { get; set; }
        public int CoverageTypeID { get; set; }
        public int CoveragePercentage { get; set; }
        public int CoverageTimeElapsed { get; set; }
        public DateTime Startdate { get; set; }
        public float TotalCost { get; set; }
        public int RiskTypeID { get; set; }
        public int StatusTypeID { get; set; }
    }
}
