using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class AppointmentMember
    {
        public int AppointmentsId { get; set; }
        public int MemberActivityId { get; set; }
        public int MemberId { get; set; }
    }
}
