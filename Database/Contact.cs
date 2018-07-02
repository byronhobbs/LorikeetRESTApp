using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Contact
    {
        public string ContactAddress { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactType { get; set; }
        public int MemberId { get; set; }
    }
}
