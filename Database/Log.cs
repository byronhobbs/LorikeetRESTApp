using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Log
    {
        public DateTime DateTime { get; set; }
        public int ErrorCode { get; set; }
        public int LogId { get; set; }
        public string Message { get; set; }
        public int RefreshCode { get; set; }
        public int StaffId { get; set; }
    }
}
