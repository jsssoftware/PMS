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
    
    public partial class tblClaimData
    {
        public int ClaimId { get; set; }
        public int PolicyId { get; set; }
        public Nullable<short> VerticalId { get; set; }
        public System.DateTime ClaimEntryDate { get; set; }
        public string ClaimNo { get; set; }
        public Nullable<int> ClaimTypeId { get; set; }
        public Nullable<System.DateTime> ClaimSubmissionDate { get; set; }
        public string ClaimSubmittedBy { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNo { get; set; }
        public Nullable<int> ClaimAmtSubmitted { get; set; }
        public string ClaimReason { get; set; }
        public short ClaimStatusId { get; set; }
        public Nullable<int> ClaimSubStatusId { get; set; }
        public Nullable<System.DateTime> FollowupDate { get; set; }
        public string FollowupReason { get; set; }
        public string ClaimRemarkbyCompany { get; set; }
        public Nullable<int> ClaimAmtApproved { get; set; }
        public string FinalRemark { get; set; }
        public string PatientName { get; set; }
        public Nullable<System.DateTime> DateOfAdmission { get; set; }
        public Nullable<System.DateTime> DateOfDischarge { get; set; }
        public string HospitalName { get; set; }
        public Nullable<System.DateTime> DocumentSubmitDate { get; set; }
        public string AccidentDetails { get; set; }
        public string WorkshopName { get; set; }
        public string WorkshopNo { get; set; }
        public string ServiceAdvisorName { get; set; }
        public string ServiceAdvisorNo { get; set; }
        public string SurveyorName { get; set; }
        public string SurveyorNo { get; set; }
        public string SurveyorEmail { get; set; }
        public string EstimateAmount { get; set; }
        public string VisibleDamage { get; set; }
        public string PendngConcerns { get; set; }
        public string NatureofClaim { get; set; }
        public Nullable<short> ClaimEntryBranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDatetime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
    }
}