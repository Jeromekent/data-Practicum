using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class Overtime
    {
        public int OverNum { get; set; }
        public int? WId { get; set; }
        public DateTime? OverStartTime { get; set; }
        public DateTime? OverEndTime { get; set; }
        public float? OverDuration { get; set; }

        public virtual Worker W { get; set; }
    }
}
