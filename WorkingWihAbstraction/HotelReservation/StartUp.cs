using System;

namespace HotelReservation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            //
            if (input.Length==4)
            {
                decimal price = decimal.Parse(input[0]);
                int days = int.Parse(input[1]);
                var sea = input[2];
                var dis = input[3];
                Enum.TryParse(sea, out Season season);
                Enum.TryParse(dis, out Discount discount);
                var resulT = PriceCalculator.Calculate(price, days, season, discount);
                Console.WriteLine($"{resulT:f2}");
            }
            else
            {
                decimal price = decimal.Parse(input[0]);
                int days = int.Parse(input[1]);
                Enum.TryParse(input[2], out Season season);
                var resulT = PriceCalculator.CalculateS(price, days, season);
                Console.WriteLine($"{resulT:f2}");
            }



        }
    }
}
