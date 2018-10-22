using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    class Departments
    {

        private List<List<string>> departments;

        public Departments(List<List<string>> departments)
        {
            this.Department = departments;
        }

        public List<List<string>> Department
        {
            get { return departments; }
            set { departments = value; }
        }


    }
}
