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
    
    public partial class topic_coverage
    {
        public int TopicCoverageID { get; set; }
        public Nullable<int> TqCoverageID { get; set; }
        public Nullable<int> SyllabusID { get; set; }
        public Nullable<double> HoursSpent { get; set; }
        public Nullable<double> Proportion { get; set; }
        public Nullable<short> RememberU { get; set; }
        public Nullable<short> RememberA { get; set; }
        public Nullable<short> UnderstandU { get; set; }
        public Nullable<short> UnderstandA { get; set; }
        public Nullable<short> ApplyU { get; set; }
        public Nullable<short> ApplyA { get; set; }
        public Nullable<short> AnalyzeU { get; set; }
        public Nullable<short> AnalyzeA { get; set; }
        public Nullable<short> EvaluateU { get; set; }
        public Nullable<short> EvaluateA { get; set; }
        public Nullable<short> CreateU { get; set; }
        public Nullable<short> CreateA { get; set; }
        public Nullable<double> TotalItemsRequired { get; set; }
    
        public virtual syllabu syllabu { get; set; }
        public virtual tq_coverage tq_coverage { get; set; }
    }
}
