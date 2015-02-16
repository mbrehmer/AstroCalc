using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AstroCalc;

namespace AstroCalc.UnitTests
{
	[TestClass]
	public class DateAndTime
	{
		[TestMethod]
		public void DateOfEaster2009()
		{
			DateTime date = AstroCalc.DateAndTime.DateOfEaster(2009);
			DateTime easter2009 = new DateTime(2009, 4, 12);

			Assert.AreEqual(date.ToShortDateString(), easter2009.ToShortDateString());
		}

		[TestMethod]
		public void DateOfEaster2012()
		{
			DateTime date = AstroCalc.DateAndTime.DateOfEaster(2012);
			DateTime easter2012 = new DateTime(2012, 4, 8);

			Assert.AreEqual(date.ToShortDateString(), easter2012.ToShortDateString());
		}

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
	}
}