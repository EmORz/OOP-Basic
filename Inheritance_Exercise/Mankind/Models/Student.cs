

namespace Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private string facultyNum;

        public Student(string firstName, string lastName, string facultyNum) : base(firstName, lastName)
        {
            this.FacultyNum = facultyNum;
        }

        public string FacultyNum
        {
            get => facultyNum; set
            {
                if (value.Length < 5 || value.Length > 10|| !(value.All(Char.IsLetterOrDigit)))
                {
                    throw new ArgumentException($"Invalid faculty number!");
               
                }
                facultyNum = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
               .AppendLine($"Faculty number: {this.FacultyNum}");
            
            return sb.ToString();
        }
    }
}
