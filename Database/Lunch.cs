using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Lunch
    {
        public DateTime Date { get; set; }
        public int LunchId { get; set; }
        public sbyte Main { get; set; }
        public string Name { get; set; }
        public sbyte Paid { get; set; }
        public int? StaffId { get; set; }
        public sbyte TakeAway { get; set; }
    }
}
