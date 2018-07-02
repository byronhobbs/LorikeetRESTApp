using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class SignIn
    {
        public int? GuestId { get; set; }
        public int? MemberId { get; set; }
        public string MethodOfSigningIn { get; set; }
        public int SigninId { get; set; }
        public DateTime? Timein { get; set; }
        public DateTime? Timeout { get; set; }
    }
}
