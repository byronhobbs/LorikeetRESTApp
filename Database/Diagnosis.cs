using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public int DiagnosisNameId { get; set; }
        public int MemberId { get; set; }
    }
}
