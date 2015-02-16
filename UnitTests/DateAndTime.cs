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
			Assert.AreEqual(date.ToShortTimeString(), easter2009.ToShortTimeString());
		}
	}
}