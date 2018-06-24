using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }
        public int? MemberId { get; set; }
    }
}
