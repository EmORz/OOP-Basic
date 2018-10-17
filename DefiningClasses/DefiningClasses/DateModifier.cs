using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static DateTime d1;
        public static DateTime d2;


        public void TakeDate(string day1, string day2)
        {
            string[] tokens = day1.Split();
            int year1 = int.Parse(tokens[0]);
            int month1 = int.Parse(tokens[1]);
            int days1 = int.Parse(tokens[2]);
            //
            string[] tokens2 = day2.Split();
            int year2 = int.Parse(tokens2[0]);
            int month2 = int.Parse(tokens2[1]);
            int days2 = int.Parse(tokens2[2]);

           d1 = new DateTime(year1, month1, days1);
           d2 = new DateTime(year2, month2, days2);

        }

        public void Diff()
        {
            TimeSpan total = d1-d2;
            var tempD = total.TotalDays;
            Console.WriteLine(Math.Abs(tempD));
        }
    }
}
