namespace Mankind
{
    using System;
    using System.Text;

    public class Worker: Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string fisrtname, string lastName, decimal weekSalary, double workHoursPerDay)
            :base(fisrtname, lastName)
        {
           this.WeekSalary = weekSalary;
           this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value<=10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {

                if (value < 1 || value>12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }
        private decimal GetMoneyPerHour()
        {
            var temp = this.WeekSalary / (5 * Convert.ToDecimal(this.WorkHoursPerDay));
            return temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
                .Append($"Salary per hour: {this.GetMoneyPerHour():f2}");
            return sb.ToString();
        }

    }
}
