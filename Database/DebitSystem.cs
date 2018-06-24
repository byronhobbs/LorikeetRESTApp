using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class DebitSystem
    {
        public int DebitId { get; set; }
        public int MemberId { get; set; }
        public int StaffId { get; set; }
        public DateTime Date { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? RunningTotal { get; set; }
        public string Details { get; set; }

        public Member Member { get; set; }
        public Staff Staff { get; set; }
    }
}
