using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingCalendar
{
    class Appointment
    {
        public DateTime Date { get; }
        public string doctorID { get; set; }
        public string patientID { get; set; }
    }
}
