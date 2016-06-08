using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OctopusDemo.UnitTests
{
	[TestFixture]
    public class DemoTests
    {
		[Test]
		public void TestThis()
		{
			Assert.That(1, Is.EqualTo(1));
		}
    }
}
