using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Guest
    {
        public string FullName { get; set; }
        public int GuestId { get; set; }
        public byte[] Picture { get; set; }
    }
}
