//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODMS.Models
{
    using System;
    
    public partial class RPT_Realtime_DayEndReport_Result
    {
        public Nullable<System.DateTime> LastWorkingday { get; set; }
        public Nullable<int> NotWorking { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int DB_Id { get; set; }
        public string DB_Name { get; set; }
        public int CEAREA_id { get; set; }
        public string CEAREA_Name { get; set; }
        public int AREA_id { get; set; }
        public string AREA_Name { get; set; }
        public int REGION_id { get; set; }
        public string REGION_Name { get; set; }
        public int Status { get; set; }
        public string Cluster { get; set; }
        public string DBCode { get; set; }
        public string OfficeAddress { get; set; }
    }
}
