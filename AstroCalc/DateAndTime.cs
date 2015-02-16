using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroCalc
{
    public static class DateAndTime
    {
		 /// <summary>
		 /// Calculates the date of Easter for a given year.
		 /// </summary>
		 /// <param name="date">Date and Time for the calculation</param>
		 /// <returns>The date of Ester</returns>
		 public static DateTime DateOfEaster(int year)
		 {
			 int a = year % 19;
			 double b = Math.Truncate(year / 100.0); // Who doesn't Math.Truncate() return an Integer ???
			 int c = year % 100;
			 double d = Math.Truncate(b / 4.0);
			 int e = Convert.ToInt32(b) % 4;
			 double f = Math.Truncate((b + 8) / 25.0);
			 double g = Math.Truncate((b - f + 1.0) / 3.0);
			 int h = (19*a + Convert.ToInt32(b) - Convert.ToInt32(d) - Convert.ToInt32(g) + 15) % 30;
			 double i = Math.Truncate(c / 4.0);
			 int k = c % 4;
			 int l = (32 + 2*e + 2*Convert.ToInt32(i) - h - k) % 7;
			 double m = Math.Truncate((a + 11*h + 22*l) / 451.0);
			 double n = Math.Truncate((h + l - 7*m + 114) / 31.0);
			 int p = (h + l - 7*Convert.ToInt32(m) + 114) % 31;

			 DateTime DateOfEaster = new DateTime(year, Convert.ToInt32(n), p+1);
			 return DateOfEaster;
		 }
    }
}