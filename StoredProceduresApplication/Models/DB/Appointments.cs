using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoredProceduresApplication.Models.DB
{
    public partial class Appointments
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
