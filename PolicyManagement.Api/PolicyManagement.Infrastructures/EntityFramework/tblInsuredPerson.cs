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
    
    public partial class tblInsuredPerson
    {
        public int InsuredPersonId { get; set; }
        public int PolicyId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string InsuredPersonName { get; set; }
        public Nullable<short> InsuredGenderId { get; set; }
        public Nullable<System.DateTime> InsuredDOB { get; set; }
        public Nullable<int> InsuredAge { get; set; }
        public Nullable<short> InsuredRelationId { get; set; }
        public Nullable<int> SumInsuredIndividual { get; set; }
        public Nullable<int> SumInsuredFloater { get; set; }
        public string PassportNo { get; set; }
        public Nullable<int> CummulativeBonus { get; set; }
        public Nullable<int> Deductable { get; set; }
        public Nullable<decimal> Loading { get; set; }
        public string LoadingReason { get; set; }
        public string NomineeName { get; set; }
        public Nullable<short> NomineeRelationId { get; set; }
        public Nullable<short> PEDId { get; set; }
        public string PEDExclusion { get; set; }
        public Nullable<short> PPCId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<int> AnnualIncome { get; set; }
        public Nullable<short> OccupationId { get; set; }
        public Nullable<short> RiskClassId { get; set; }
        public short BranchId { get; set; }
    }
}