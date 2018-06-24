using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Login
    {
        public Login()
        {
            Staff = new HashSet<Staff>();
        }

        public int LoginId { get; set; }
        public string LoginName { get; set; }
        public string LoginPass { get; set; }
        public int? Access { get; set; }
        public int? Pin { get; set; }

        public ICollection<Staff> Staff { get; set; }
    }
}
