using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OctopusDemo.IntegrationTests
{
	[TestFixture]
    public class TestTheApp
    {
		[Test]
		public void RunATest()
		{
			Assert.That(1, Is.EqualTo(1));
		}
    }
}
