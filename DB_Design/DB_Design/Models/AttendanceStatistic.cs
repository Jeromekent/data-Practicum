using System;
using System.Collections.Generic;

namespace DB_Design.Models
{
    public partial class AttendanceStatistic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? LateTimes { get; set; }
        public decimal? LeaveEarlyTimes { get; set; }
        public decimal? AbsenteeismTimes { get; set; }
        public decimal? NormalTimes { get; set; }
    }
}
