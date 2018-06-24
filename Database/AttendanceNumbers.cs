using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class AttendanceNumbers
    {
        public int AttendanceNumbersId { get; set; }
        public DateTime? Date { get; set; }
        public int? Number { get; set; }
    }
}
