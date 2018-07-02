using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Resources
    {
        public int? Color { get; set; }
        public string CustomField1 { get; set; }
        public byte[] Image { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int UniqueId { get; set; }
    }
}
