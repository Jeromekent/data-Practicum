using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class Attendance
    {
        public int AttNum { get; set; }
        public int? WId { get; set; }
        public DateTime? AttStartTime { get; set; }
        public DateTime? AttEndTime { get; set; }
        public string AttAbsence { get; set; }

        public virtual Worker W { get; set; }
    }
}
