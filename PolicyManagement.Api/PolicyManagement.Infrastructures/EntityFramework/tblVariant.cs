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
    
    public partial class tblVariant
    {
        public int VariantId { get; set; }
        public short ManufacturerId { get; set; }
        public short ModelId { get; set; }
        public string VariantName { get; set; }
        public int ExShowroomValue { get; set; }
        public short FuelTypeId { get; set; }
        public int VehicleClassId { get; set; }
        public Nullable<int> CubicCapacity { get; set; }
        public Nullable<short> SeatCapacity { get; set; }
        public Nullable<int> GVW { get; set; }
        public Nullable<int> KW { get; set; }
        public string VariantCode { get; set; }
        public Nullable<int> VehicleSegmentId { get; set; }
        public string SearchVehicle { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}
