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
    
    public partial class tblAddonPlanOption
    {
        public int AddonPlanOptionId { get; set; }
        public string AddonPlanOptionName { get; set; }
        public string AddonPlanOptionDescripation { get; set; }
        public int VerticalId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<short> DisplayOrder { get; set; }
    }
}
