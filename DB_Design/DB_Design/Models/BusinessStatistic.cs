using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class BusinessStatistic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public double? TotalBusDuration { get; set; }
    }
}
