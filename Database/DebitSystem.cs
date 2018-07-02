using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class DebitSystem
    {
        public decimal? Credit { get; set; }
        public DateTime Date { get; set; }
        public decimal? Debit { get; set; }
        public int DebitId { get; set; }
        public string Details { get; set; }
        public int MemberId { get; set; }
        public decimal? RunningTotal { get; set; }
        public int StaffId { get; set; }
    }
}
