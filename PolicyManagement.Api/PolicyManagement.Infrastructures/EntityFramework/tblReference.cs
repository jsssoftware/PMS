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
    
    public partial class tblReference
    {
        public int ReferenceId { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceCode { get; set; }
        public string ReferenceAddress { get; set; }
        public Nullable<int> ReferenceCityId { get; set; }
        public string ReferenceMobile1 { get; set; }
        public string ReferenceMobile2 { get; set; }
        public string ReferenceEmail { get; set; }
        public Nullable<System.DateTime> ReferenceDOB { get; set; }
        public Nullable<short> ReferenceCategoryId { get; set; }
        public Nullable<short> ReferenceTypeId { get; set; }
        public Nullable<bool> CommunicationSend { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<short> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}
