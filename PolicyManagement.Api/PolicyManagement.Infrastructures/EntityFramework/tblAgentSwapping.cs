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
    
    public partial class tblAgentSwapping
    {
        public int AgentSwappingId { get; set; }
        public string ReasonOfChange { get; set; }
        public string DataChangeType { get; set; }
        public Nullable<System.DateTime> SwappingDate { get; set; }
        public Nullable<int> ControlNo { get; set; }
        public Nullable<int> PolicyId { get; set; }
        public Nullable<int> POSId { get; set; }
        public string POS { get; set; }
        public string Telecaller { get; set; }
        public string FOS { get; set; }
        public string Reference { get; set; }
        public string BusinessDoneBy { get; set; }
        public string PolicyRemarks { get; set; }
        public Nullable<int> OD { get; set; }
        public Nullable<int> GrossPremium { get; set; }
        public Nullable<int> VerticalId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<short> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public short DSACommMonthCycleIId { get; set; }
        public short DSACommissionReceived { get; set; }
    }
}
