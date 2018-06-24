using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Lunch
    {
        public int LunchId { get; set; }
        public string Name { get; set; }
        public sbyte Paid { get; set; }
        public sbyte TakeAway { get; set; }
        public sbyte Main { get; set; }
        public int? StaffId { get; set; }
        public DateTime Date { get; set; }

        public Staff Staff { get; set; }
    }
}
