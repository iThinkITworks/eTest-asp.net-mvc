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
    
    public partial class system_logs
    {
        public int SystemLogID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> EntryDateTime { get; set; }
        public string Activity { get; set; }
    
        public virtual user user { get; set; }
    }
}
