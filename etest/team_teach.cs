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
    
    public partial class team_teach
    {
        public team_teach()
        {
            this.tq_coverage = new HashSet<tq_coverage>();
        }
    
        public int TeamTeachID { get; set; }
        public Nullable<int> CurriculumID { get; set; }
        public string SchoolYear { get; set; }
        public string Semester { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual curriculum curriculum { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<tq_coverage> tq_coverage { get; set; }
    }
}
