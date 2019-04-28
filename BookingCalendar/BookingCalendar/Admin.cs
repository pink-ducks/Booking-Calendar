using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingCalendar
{
    class Admin
    {
        public string adminID { get; set; }
        List<Patient> Patients = new List<Patient>();
        List<Doctor> Doctors = new List<Doctor>();
        List<Appointment> Appointments = new List<Appointment>();
    }
}
