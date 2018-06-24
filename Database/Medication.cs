using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Medication
    {
        public int MedicationId { get; set; }
        public int MemberId { get; set; }
        public int MedicationNameId { get; set; }

        public Member Member { get; set; }
    }
}
