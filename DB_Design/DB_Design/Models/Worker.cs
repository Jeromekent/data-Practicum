using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Attendance = new HashSet<Attendance>();
            Business = new HashSet<Business>();
            Offwork = new HashSet<Offwork>();
            Overtime = new HashSet<Overtime>();
        }

        public int WId { get; set; }
        public string WName { get; set; }
        public string WSex { get; set; }
        public int? WAge { get; set; }
        public string WTelephone { get; set; }
        public int? WDepartment { get; set; }
        public string WPost { get; set; }
        public string WDuty { get; set; }
        public int? WWage { get; set; }
        public string WOnJob { get; set; }

        public virtual Department WDepartmentNavigation { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<Business> Business { get; set; }
        public virtual ICollection<Offwork> Offwork { get; set; }
        public virtual ICollection<Overtime> Overtime { get; set; }
    }
}
