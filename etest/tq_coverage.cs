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
    
    public partial class tq_coverage
    {
        public tq_coverage()
        {
            this.topic_coverage = new HashSet<topic_coverage>();
            this.tqs = new HashSet<tq>();
            this.tq_coverage_log = new HashSet<tq_coverage_log>();
        }
    
        public int TqCoverageID { get; set; }
        public Nullable<int> CurriculumID { get; set; }
        public Nullable<int> TeamTeachID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<double> TotalHoursCoverage { get; set; }
        public Nullable<short> TotalItems { get; set; }
        public string Status { get; set; }
    
        public virtual curriculum curriculum { get; set; }
        public virtual team_teach team_teach { get; set; }
        public virtual ICollection<topic_coverage> topic_coverage { get; set; }
        public virtual ICollection<tq> tqs { get; set; }
        public virtual ICollection<tq_coverage_log> tq_coverage_log { get; set; }
    }
}
