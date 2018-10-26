

namespace Mankind
{
    using System;
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
                if (value.Length<5||value.Length>10)
                {
                    Exception ex = new ArgumentException($"Invalid faculty number!");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                facultyNum = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Faculty number: {this.FacultyNum}");
            
            return sb.ToString().TrimEnd();
        }
    }
}
