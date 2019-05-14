using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingCalendar
{
    class AdminContainer : ISingletonContainer
    {
        private List<Patient> patients { set; get; }
        private List <AdminClass> admins { set; get; }
        private List<Doctor> doctors { set; get; }
        public AdminContainer()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\yourFile.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                int age = Int32.Parse(words[2]);
                patients.Add(new Patient(words[0], words[1], age, words[3], words[4], words[5], words[6]));
            }

            file.Close();


        }
        private static Lazy<AdminContainer> instance = new Lazy<AdminContainer>(() => new AdminContainer());
        public static AdminContainer Instance => instance.Value;
    }
    /*private static AdminContainer instance = new AdminContainer();
     public static ISingletonContainer Instance => instance;
*/
}
}
