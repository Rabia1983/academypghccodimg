using NUnit.Framework;
using System;
using libraryfile;
namespace thethirdfile
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			Assert.IsTrue(true);
		}
		[Test()]
		public void Given_1_return_I()
		{
			RomanConvertor rc = new RomanConvertor();
			Assert.AreEqual(rc.GetRoman(1), "I");
		}

	}
}
