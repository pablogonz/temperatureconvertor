using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureconver
{
    public class temperature
    {
        public static double ctof(double c)
        {

            return ((9.0 / 5.0) * c) + 32;
            
            
          
        }
        public static double ftoc(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }
        public static double ctok(double c)
        {
            return (c + 273.15);
        }
        public static object ftok(double f)
        {
            return (f- 32) * 5.0 / 9.0 +273.15;
        }
        static void Main(string[] args)
        {

        }
    }
}
