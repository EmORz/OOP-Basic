using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal Calculate(decimal price, int days, Season seasons, Discount typeClient)
        {
            var temp = (price * days) * (int)seasons * ((100-(decimal)typeClient)/100);
            return temp;
        }

        public static decimal CalculateS(decimal price, int days, Season seasons)
        {
            var temp = (price * days) * (int)seasons;
            return temp;
        }
    }
}
