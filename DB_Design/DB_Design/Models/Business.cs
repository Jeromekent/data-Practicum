using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class Business
    {
        public int BusNum { get; set; }
        public int? WId { get; set; }
        public DateTime? BusStartTime { get; set; }
        public DateTime? BusEndTime { get; set; }
        public float? BusDuration { get; set; }

        public virtual Worker W { get; set; }
    }
}
