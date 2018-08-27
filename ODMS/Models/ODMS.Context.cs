﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ODMSEntities : DbContext
    {
        public ODMSEntities()
            : base("name=ODMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_calendar> tbl_calendar { get; set; }
        public virtual DbSet<tbl_MainMenu> tbl_MainMenu { get; set; }
        public virtual DbSet<tbl_Manu_Role_mapping> tbl_Manu_Role_mapping { get; set; }
        public virtual DbSet<tbl_SubMenu> tbl_SubMenu { get; set; }
        public virtual DbSet<tbl_SubMenuSecond> tbl_SubMenuSecond { get; set; }
        public virtual DbSet<tbld_AdjustmentStock> tbld_AdjustmentStock { get; set; }
        public virtual DbSet<tbld_AdjustmentStockItem> tbld_AdjustmentStockItem { get; set; }
        public virtual DbSet<tbld_bundle_price> tbld_bundle_price { get; set; }
        public virtual DbSet<tbld_bundle_price_details> tbld_bundle_price_details { get; set; }
        public virtual DbSet<tbld_business_zone> tbld_business_zone { get; set; }
        public virtual DbSet<tbld_business_zone_hierarchy> tbld_business_zone_hierarchy { get; set; }
        public virtual DbSet<tbld_cluster> tbld_cluster { get; set; }
        public virtual DbSet<tbld_distribution_employee> tbld_distribution_employee { get; set; }
        public virtual DbSet<tbld_distribution_employee_Type> tbld_distribution_employee_Type { get; set; }
        public virtual DbSet<tbld_distribution_house> tbld_distribution_house { get; set; }
        public virtual DbSet<tbld_distributor_Route> tbld_distributor_Route { get; set; }
        public virtual DbSet<tbld_distributor_RouteType> tbld_distributor_RouteType { get; set; }
        public virtual DbSet<tbld_management_employee> tbld_management_employee { get; set; }
        public virtual DbSet<tbld_Outlet> tbld_Outlet { get; set; }
        public virtual DbSet<tbld_Outlet_category> tbld_Outlet_category { get; set; }
        public virtual DbSet<tbld_Outlet_channel> tbld_Outlet_channel { get; set; }
        public virtual DbSet<tbld_Outlet_grade> tbld_Outlet_grade { get; set; }
        public virtual DbSet<tbld_Outlet_new> tbld_Outlet_new { get; set; }
        public virtual DbSet<tbld_ReportList> tbld_ReportList { get; set; }
        public virtual DbSet<tbld_Route_Plan> tbld_Route_Plan { get; set; }
        public virtual DbSet<tbld_Route_plan_Current_Route> tbld_Route_plan_Current_Route { get; set; }
        public virtual DbSet<tbld_Route_Plan_Detail> tbld_Route_Plan_Detail { get; set; }
        public virtual DbSet<tbld_Route_Plan_Mapping> tbld_Route_Plan_Mapping { get; set; }
        public virtual DbSet<tbld_SKU> tbld_SKU { get; set; }
        public virtual DbSet<tbld_SKU_Brand> tbld_SKU_Brand { get; set; }
        public virtual DbSet<tbld_SKU_Brand_category> tbld_SKU_Brand_category { get; set; }
        public virtual DbSet<tbld_sku_category> tbld_sku_category { get; set; }
        public virtual DbSet<tbld_SKU_unit> tbld_SKU_unit { get; set; }
        public virtual DbSet<tbld_SKUContainertype> tbld_SKUContainertype { get; set; }
        public virtual DbSet<tbld_SKUtype> tbld_SKUtype { get; set; }
        public virtual DbSet<tbld_Target> tbld_Target { get; set; }
        public virtual DbSet<tbld_Target_Details> tbld_Target_Details { get; set; }
        public virtual DbSet<tbld_Target_PSR_Details> tbld_Target_PSR_Details { get; set; }
        public virtual DbSet<tbll_inventory_log> tbll_inventory_log { get; set; }
        public virtual DbSet<tblt_Challan> tblt_Challan { get; set; }
        public virtual DbSet<tblt_Challan_line> tblt_Challan_line { get; set; }
        public virtual DbSet<tblt_inventory> tblt_inventory { get; set; }
        public virtual DbSet<tblt_Order> tblt_Order { get; set; }
        public virtual DbSet<tblt_Order_line> tblt_Order_line { get; set; }
        public virtual DbSet<tblt_Order_Line_type> tblt_Order_Line_type { get; set; }
        public virtual DbSet<tblt_OrderType> tblt_OrderType { get; set; }
        public virtual DbSet<tblt_PurchaseOrder> tblt_PurchaseOrder { get; set; }
        public virtual DbSet<tblt_PurchaseOrderLine> tblt_PurchaseOrderLine { get; set; }
        public virtual DbSet<tblt_System> tblt_System { get; set; }
        public virtual DbSet<tblt_TradePromotion> tblt_TradePromotion { get; set; }
        public virtual DbSet<tblt_TradePromotionConditionType> tblt_TradePromotionConditionType { get; set; }
        public virtual DbSet<tblt_TradePromotionDBhouseMapping> tblt_TradePromotionDBhouseMapping { get; set; }
        public virtual DbSet<tblt_TradePromotionDefinition> tblt_TradePromotionDefinition { get; set; }
        public virtual DbSet<tblt_TradePromotionOfferType> tblt_TradePromotionOfferType { get; set; }
        public virtual DbSet<tblt_TradePromotionRule> tblt_TradePromotionRule { get; set; }
        public virtual DbSet<tblt_TradePromotionType> tblt_TradePromotionType { get; set; }
        public virtual DbSet<user_info> user_info { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }
        public virtual DbSet<tblm_notorder_reason> tblm_notorder_reason { get; set; }
        public virtual DbSet<tbld_db_psr_outlet_zone_view> tbld_db_psr_outlet_zone_view { get; set; }
        public virtual DbSet<tbld_db_psr_zone_view> tbld_db_psr_zone_view { get; set; }
        public virtual DbSet<tbld_db_zone_view> tbld_db_zone_view { get; set; }
        public virtual DbSet<tblm_visit_detail> tblm_visit_detail { get; set; }
        public virtual DbSet<tblm_UserLogin> tblm_UserLogin { get; set; }
    
        public virtual ObjectResult<DB_User_check_Result> DB_User_check(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DB_User_check_Result>("DB_User_check", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<DBidbyASM_Result> DBidbyASM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DBidbyASM_Result>("DBidbyASM");
        }
    
        public virtual ObjectResult<DBidbyCE_Result> DBidbyCE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DBidbyCE_Result>("DBidbyCE");
        }
    
        public virtual ObjectResult<Nullable<int>> DBidbyNSM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DBidbyNSM");
        }
    
        public virtual ObjectResult<DBidbyRSM_Result> DBidbyRSM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DBidbyRSM_Result>("DBidbyRSM");
        }
    
        public virtual ObjectResult<ShowInventory_Result> ShowInventory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowInventory_Result>("ShowInventory");
        }
    
        public virtual ObjectResult<User_check_Result> User_check(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<User_check_Result>("User_check", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<RPT_OrderVsStock_Result> RPT_OrderVsStock(Nullable<int> dBID)
        {
            var dBIDParameter = dBID.HasValue ?
                new ObjectParameter("DBID", dBID) :
                new ObjectParameter("DBID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_OrderVsStock_Result>("RPT_OrderVsStock", dBIDParameter);
        }
    
        public virtual ObjectResult<RPT_ChallanVsDelivery_Result> RPT_ChallanVsDelivery(Nullable<int> challan_no)
        {
            var challan_noParameter = challan_no.HasValue ?
                new ObjectParameter("Challan_no", challan_no) :
                new ObjectParameter("Challan_no", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_ChallanVsDelivery_Result>("RPT_ChallanVsDelivery", challan_noParameter);
        }
    
        public virtual ObjectResult<DBWisezone_Result> DBWisezone()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DBWisezone_Result>("DBWisezone");
        }
    
        public virtual int DayEnd_Process(Nullable<int> dbid, Nullable<System.DateTime> batchDate)
        {
            var dbidParameter = dbid.HasValue ?
                new ObjectParameter("Dbid", dbid) :
                new ObjectParameter("Dbid", typeof(int));
    
            var batchDateParameter = batchDate.HasValue ?
                new ObjectParameter("BatchDate", batchDate) :
                new ObjectParameter("BatchDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DayEnd_Process", dbidParameter, batchDateParameter);
        }
    
        public virtual ObjectResult<RPT_CurrentStock_Result> RPT_CurrentStock(string dbids)
        {
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_CurrentStock_Result>("RPT_CurrentStock", dbidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_OrderVsdeliveredSummary_Result> RPT_Realtime_OrderVsdeliveredSummary(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids, string skuids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            var skuidsParameter = skuids != null ?
                new ObjectParameter("skuids", skuids) :
                new ObjectParameter("skuids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_OrderVsdeliveredSummary_Result>("RPT_Realtime_OrderVsdeliveredSummary", start_DateParameter, end_DateParameter, dbidsParameter, skuidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_OrderVsdeliveredDBDetails_Result> RPT_Realtime_OrderVsdeliveredDBDetails(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids, string skuids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            var skuidsParameter = skuids != null ?
                new ObjectParameter("skuids", skuids) :
                new ObjectParameter("skuids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_OrderVsdeliveredDBDetails_Result>("RPT_Realtime_OrderVsdeliveredDBDetails", start_DateParameter, end_DateParameter, dbidsParameter, skuidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_OrderVsdeliveredDBSummary_Result> RPT_Realtime_OrderVsdeliveredDBSummary(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids, string skuids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            var skuidsParameter = skuids != null ?
                new ObjectParameter("skuids", skuids) :
                new ObjectParameter("skuids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_OrderVsdeliveredDBSummary_Result>("RPT_Realtime_OrderVsdeliveredDBSummary", start_DateParameter, end_DateParameter, dbidsParameter, skuidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_OrderVsdeliveredDetails_Result> RPT_Realtime_OrderVsdeliveredDetails(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids, string skuids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            var skuidsParameter = skuids != null ?
                new ObjectParameter("skuids", skuids) :
                new ObjectParameter("skuids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_OrderVsdeliveredDetails_Result>("RPT_Realtime_OrderVsdeliveredDetails", start_DateParameter, end_DateParameter, dbidsParameter, skuidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_DBLifting_Result> RPT_Realtime_DBLifting(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_DBLifting_Result>("RPT_Realtime_DBLifting", start_DateParameter, end_DateParameter, dbidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_TradepromotionDetails_Result> RPT_Realtime_TradepromotionDetails(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_TradepromotionDetails_Result>("RPT_Realtime_TradepromotionDetails", start_DateParameter, end_DateParameter, dbidsParameter);
        }
    
        public virtual ObjectResult<RPT_TP_List_Result> RPT_TP_List(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_TP_List_Result>("RPT_TP_List", start_DateParameter, end_DateParameter, dbidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_SKUWiseOrder_Result> RPT_Realtime_SKUWiseOrder(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids, string skuids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            var skuidsParameter = skuids != null ?
                new ObjectParameter("skuids", skuids) :
                new ObjectParameter("skuids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_SKUWiseOrder_Result>("RPT_Realtime_SKUWiseOrder", start_DateParameter, end_DateParameter, dbidsParameter, skuidsParameter);
        }
    
        public virtual ObjectResult<RPT_Realtime_OutletWiseOrder_Result> RPT_Realtime_OutletWiseOrder(Nullable<System.DateTime> start_Date, Nullable<System.DateTime> end_Date, string dbids)
        {
            var start_DateParameter = start_Date.HasValue ?
                new ObjectParameter("Start_Date", start_Date) :
                new ObjectParameter("Start_Date", typeof(System.DateTime));
    
            var end_DateParameter = end_Date.HasValue ?
                new ObjectParameter("End_Date", end_Date) :
                new ObjectParameter("End_Date", typeof(System.DateTime));
    
            var dbidsParameter = dbids != null ?
                new ObjectParameter("dbids", dbids) :
                new ObjectParameter("dbids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPT_Realtime_OutletWiseOrder_Result>("RPT_Realtime_OutletWiseOrder", start_DateParameter, end_DateParameter, dbidsParameter);
        }
    }
}
