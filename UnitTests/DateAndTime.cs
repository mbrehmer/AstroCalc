using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AstroCalc;

namespace AstroCalc.UnitTests
{
	/// <summary>
	/// This class provides the Unit Tests for the Class AstroCalc.DateAndTime
	/// </summary>
	[TestClass]
	public class DateAndTime
	{
		/// <summary>
		/// This method tests the function AstroCalc.DateAndTime.DateOfEaster() with the parameter 2009;
		/// </summary>
		[TestMethod]
		public void DateOfEaster2009()
		{
			DateTime date = AstroCalc.DateAndTime.DateOfEaster(2009);
			DateTime easter2009 = new DateTime(2009, 4, 12);

			Assert.AreEqual(date.ToShortDateString(), easter2009.ToShortDateString());
		}

		/// <summary>
		/// This method tests the function AstroCalc.DateAndTime.DateOfEaster() with the parameter 2012;
		/// </summary>
		[TestMethod]
		public void DateOfEaster2012()
		{
			DateTime date = AstroCalc.DateAndTime.DateOfEaster(2012);
			DateTime easter2012 = new DateTime(2012, 4, 8);

			Assert.AreEqual(date.ToShortDateString(), easter2012.ToShortDateString());
		}

		/// <summary>
		/// This method tests the correct throw of the exception by the method AstroCalc.DateAndTime.DateOfEaster()
		/// </summary>
		[TestMethod]
		public void DateOfEasterException()
		{
			try
			{
				DateTime date = AstroCalc.DateAndTime.DateOfEaster(1582);
				Assert.Fail("no exception thrown");
			}
			catch (Exception ex)
			{
				Assert.IsTrue(ex is System.ArgumentException);
			}
		}

		/// <summary>
		/// This method tests the AstroCalc.DateAndTime.JulianDate() with the date 19.06.2009
		/// </summary>
		[TestMethod]
		public void JulianDate1()
		{
			double JulianDate = AstroCalc.DateAndTime.JulianDate(new DateTime(2009, 6, 19));

			Assert.AreEqual(JulianDate, 2455001.5);
		}

		/// <summary>
		/// This method tests the AstroCalc.DateAndTime.JulianDate() with the date 30.07.1984
		/// </summary>
		[TestMethod]
		public void JulianDate2()
		{
			double JulianDate = AstroCalc.DateAndTime.JulianDate(new DateTime(1984, 7, 30));

			Assert.AreEqual(JulianDate, 2445911.5);
		}

		/// <summary>
		/// This method tests the AstroCalc.DateAndTime.JulianDate() with the date 12.10.1492
		/// </summary>
		[TestMethod]
		public void JulianDate3()
		{
			double JulianDate = AstroCalc.DateAndTime.JulianDate(new DateTime(1492, 10, 12));

			Assert.AreEqual(JulianDate, 2266295.5);
		}
	}
}