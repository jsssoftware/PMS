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
    
    public partial class tblPolicyAddonOptionDetails
    {
        public int PolicyAddonOptionId { get; set; }
        public int PolicyId { get; set; }
        public int AddonPlanOptionId { get; set; }
        public string AddonValue { get; set; }
    }
}