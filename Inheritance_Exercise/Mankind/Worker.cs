namespace Mankind
{
    using System;
    using System.Text;

    public class Worker:Human
    {
        private decimal salary;
        private int workHours;

        public Worker(string firstName, string lastName, decimal salary, int workHours): base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkHours = workHours;
        }

        public decimal Salary
        {
            get => salary; set
            {
                if (value<=10)
                {
                    Exception ex = new ArgumentException($"Expected value mismatch! Argument: {value}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                salary = value;
            }
        }
        public int WorkHours
        {
            get => workHours; set
            {
                if (value < 1|| value>12)
                {
                    Exception ex = new ArgumentException($"Expected value mismatch! Argument: {value}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                workHours = value;
            }
        }

        //Method
        public string SalaryPerHour()
        {
            var calculate = this.Salary / this.WorkHours / 5;

            return $"{calculate:f2}";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.Salary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHours:f2}");
            sb.AppendLine($"Salary per hour: {this.SalaryPerHour():f2}\n");
            Console.WriteLine();
            return sb.ToString().TrimEnd();
        }
    }
}
