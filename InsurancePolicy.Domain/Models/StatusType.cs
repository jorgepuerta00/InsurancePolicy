﻿namespace InsurancePolicy.Domain.Models
{
    public class StatusType : BaseEntity
    {
        public int StatusTypeID { get; set; }
        public string StatusTypeCode { get; set; }
        public string StatusTypeName { get; set; }
    }
}
