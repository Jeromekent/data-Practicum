using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Design.MyModels
{
    public class Business_Display
    {
        public int BusNum { get; set; }
        public int? WId { get; set; }
        public string WName { get; set; }
        public DateTime? BusStartTime { get; set; }
        public DateTime? BusEndTime { get; set; }
        public float? BusDuration { get; set; }
    }
}
