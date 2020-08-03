namespace InsurancePolicy.Domain.Models
{
    public class RiskType : BaseEntity
    {
        public int RiskTypeID { get; set; }
        public string RiskTypeCode { get; set; }
        public string RiskTypeName { get; set; }
        public int MaxCoverage { get; set; }
    }
}
