using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			using (var db = new ThingsContext())
			{

				var countBefore = db.Things.Count();

				var newitem = new Thingy() { Name = Guid.NewGuid().ToString() };
				db.Things.Add(newitem);
				db.SaveChanges();


				var countAfter = db.Things.Count();

				Assert.AreEqual(countBefore + 1, countAfter);

			}
		}
	}
}
