using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Staff
    {
        public Staff()
        {
            DebitSystem = new HashSet<DebitSystem>();
            Lunch = new HashSet<Lunch>();
        }

        public int StaffId { get; set; }
        public int LoginId { get; set; }
        public string StaffName { get; set; }

        public Login Login { get; set; }
        public ICollection<DebitSystem> DebitSystem { get; set; }
        public ICollection<Lunch> Lunch { get; set; }
    }
}
