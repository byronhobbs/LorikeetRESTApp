using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Guest
    {
        public Guest()
        {
            SignIn = new HashSet<SignIn>();
        }

        public int GuestId { get; set; }
        public string FullName { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<SignIn> SignIn { get; set; }
    }
}
