using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class Department
    {
        public Department()
        {
            Worker = new HashSet<Worker>();
        }

        public int DId { get; set; }
        public string DName { get; set; }

        public virtual ICollection<Worker> Worker { get; set; }
    }
}
