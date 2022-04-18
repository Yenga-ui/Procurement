using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public class Util
    {
        public static DateTime ToLocalDate(string dateString)
        {
            return DateTime.ParseExact(dateString, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTime(string start)
        {
            return ToLocalDate(start);
        }
    }
}
