//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace etest
{
    using System;
    using System.Collections.Generic;
    
    public partial class item_log
    {
        public int ItemLogID { get; set; }
        public Nullable<int> CellItemID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> DateRemarked { get; set; }
        public string ActionDone { get; set; }
    
        public virtual cell_items cell_items { get; set; }
        public virtual user user { get; set; }
    }
}