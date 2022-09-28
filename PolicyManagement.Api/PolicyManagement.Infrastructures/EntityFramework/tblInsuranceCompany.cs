//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicyManagement.Infrastructures.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblInsuranceCompany
    {
        public short InsuranceCompanyId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public Nullable<bool> IsMotor { get; set; }
        public Nullable<bool> IsHealth { get; set; }
        public Nullable<bool> IsCommercial { get; set; }
        public Nullable<bool> IsLife { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> MappedInsureCompanyId { get; set; }
        public Nullable<int> MappingReasonId { get; set; }
        public Nullable<System.DateTime> MappingApplicableFormdt { get; set; }
        public string InsCompShortName { get; set; }
        public string CompanyCode { get; set; }
        public string Website1 { get; set; }
        public string Website2 { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}
