using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProceduresApplication.Models.DB
{
    public class Input
    {
        public string Date { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
