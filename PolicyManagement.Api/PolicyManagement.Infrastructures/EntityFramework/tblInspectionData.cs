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
    
    public partial class tblInspectionData
    {
        public int InspectionId { get; set; }
        public Nullable<System.DateTime> InspectionEntryDate { get; set; }
        public string PreviousControlNo { get; set; }
        public string CustomerName { get; set; }
        public string ContactPerson { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string InspectionAddress { get; set; }
        public string RegistrationNo { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public Nullable<int> ModelId { get; set; }
        public Nullable<int> MakeYearId { get; set; }
        public Nullable<int> ReqInsuranceCompanyId { get; set; }
        public string EngineNo { get; set; }
        public string ChassisNo { get; set; }
        public System.DateTime InspectionDate { get; set; }
        public int InspectionReasonId { get; set; }
        public Nullable<int> SourcofRequestId { get; set; }
        public Nullable<int> POSId { get; set; }
        public Nullable<int> TeamMemberId { get; set; }
        public string InspectionReferNo { get; set; }
        public Nullable<int> InspectionCompanyId { get; set; }
        public string SurvyorName { get; set; }
        public string SurveyorMobile { get; set; }
        public string SurveyorEmail { get; set; }
        public Nullable<int> InspectionStatusId { get; set; }
        public Nullable<int> InspectionSubStatusId { get; set; }
        public string InspectionRemark { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDatetime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
    }
}
