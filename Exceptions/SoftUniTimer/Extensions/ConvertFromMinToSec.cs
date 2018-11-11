using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniTimer.Extensions
{
    public static class ConvertFromMinToSec
    {
        public static int ToSeconds(this int minutes)
        {
            return minutes * 60;
        }

    }
}
