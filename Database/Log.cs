using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Log
    {
        public int LogId { get; set; }
        public int StaffId { get; set; }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public int RefreshCode { get; set; }
    }
}
