using System;

namespace AstroCalc
{
	/// <summary>
	/// This class provides the funktions for dates and times
	/// </summary>
	public static class DateAndTime
	{
		/// <summary>
		/// Calculates the date of Easter for a given year after 1582
		/// </summary>
		/// <param name="year">The year for the calculation</param>
		/// <returns>The date of Easter</returns>
		/// <exception cref="System.ArgumentException">Thrown when the parameter lower then 1583</exception>
		public static DateTime DateOfEaster(int year)
		{
			if (year <= 1582)
				throw new System.ArgumentException("Parameter cannot be lower then 1583", "year");

			int a = year % 19;
			double b = Math.Truncate(year / 100.0); // Why doesn't Math.Truncate() return an Integer ???
			int c = year % 100;
			double d = Math.Truncate(b / 4.0);
			int e = Convert.ToInt32(b) % 4;
			double f = Math.Truncate((b + 8) / 25.0);
			double g = Math.Truncate((b - f + 1.0) / 3.0);
			int h = (19 * a + Convert.ToInt32(b) - Convert.ToInt32(d) - Convert.ToInt32(g) + 15) % 30;
			double i = Math.Truncate(c / 4.0);
			int k = c % 4;
			int l = (32 + 2 * e + 2 * Convert.ToInt32(i) - h - k) % 7;
			double m = Math.Truncate((a + 11 * h + 22 * l) / 451.0);
			double n = Math.Truncate((h + l - 7 * m + 114) / 31.0);
			int p = (h + l - 7 * Convert.ToInt32(m) + 114) % 31;

			DateTime DateOfEaster = new DateTime(year, Convert.ToInt32(n), p + 1);
			return DateOfEaster;
		}

		/// <summary>
		/// Calculates the Julian date for a given Gregorian date
		/// </summary>
		/// <param name="date">The date for the calculation</param>
		/// <returns>The Julian date</returns>
		public static double JulianDate(DateTime date)
		{
			int y_, m_, A, B, C, D;

			if (date.Month == 1 || date.Month == 2)
			{
				y_ = date.Year - 1;
				m_ = date.Month + 12;
			}
			else
			{
				y_ = date.Year;
				m_ = date.Month;
			}

			A = Convert.ToInt32(Math.Truncate(date.Year / 100.0));
			if (date > new DateTime(1582, 10, 15))
				B = Convert.ToInt32(Math.Truncate(A / 4.0));
			else
				B = 0;

			if (y_ < 0)
				C = Convert.ToInt32(Math.Truncate(365.25 * y_) - 0.75);
			else
				C = Convert.ToInt32(Math.Truncate(365.25 * y_));

			D = Convert.ToInt32(Math.Truncate(30.6001 * (m_+1)));

			double JulianDate = B + C + D + date.Day + 1720994.5;
			return JulianDate;
		}
	}
}