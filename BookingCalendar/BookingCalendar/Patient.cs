using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingCalendar
{
    public class Patient : Person
    {
         public string patientID { get; set; }
         public Patient(string name, string surname, int age, string sex, string mail, string phonenumber, string PatientID)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
            this.mail = mail;
            this.patientID = PatientID;
        }
    }
}
