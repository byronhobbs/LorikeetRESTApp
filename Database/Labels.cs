using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Labels
    {
        public int? Color { get; set; }
        public string DisplayName { get; set; }
        public int LabelId { get; set; }
        public string MenuCaption { get; set; }
        public string Shortcut { get; set; }
    }
}
