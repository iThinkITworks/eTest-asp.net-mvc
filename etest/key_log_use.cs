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
    
    public partial class key_log_use
    {
        public int KeyLogUseID { get; set; }
        public Nullable<int> ItemKeyID { get; set; }
        public Nullable<System.DateTime> DateUsed { get; set; }
        public Nullable<int> TqID { get; set; }
    
        public virtual item_keys item_keys { get; set; }
        public virtual tq tq { get; set; }
    }
}
