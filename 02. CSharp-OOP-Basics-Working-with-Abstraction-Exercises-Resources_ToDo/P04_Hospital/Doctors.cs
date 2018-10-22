using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    class Doctors
    {
        private string fullName;
        private List<string> patients;

        public Doctors(List<string> patients)
        {
            this.Patients = patients;
        }
                     
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public List<string> Patients
        {
            get { return patients; }
            set { patients = value; }
        }



    }
}
