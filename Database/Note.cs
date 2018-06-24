using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Note
    {
        public int NotesId { get; set; }
        public int? MemberId { get; set; }
        public int? StaffId { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }
        public sbyte? Editable { get; set; }
    }
}
