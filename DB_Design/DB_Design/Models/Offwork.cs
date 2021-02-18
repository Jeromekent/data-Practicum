using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class Offwork
    {
        public int OffNum { get; set; }
        public int? WId { get; set; }
        public DateTime? OffStartTime { get; set; }
        public DateTime? OffEndTime { get; set; }
        public float? OffDuration { get; set; }

        public virtual Worker W { get; set; }
    }
}
