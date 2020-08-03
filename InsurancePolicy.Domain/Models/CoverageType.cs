namespace InsurancePolicy.Domain.Models
{
    public class CoverageType : BaseEntity
    {
        public int CoverageTypeID { get; set; }
        public string CoverageTypeCode { get; set; }
        public string CoverageTypeName { get; set; }
    }
}
