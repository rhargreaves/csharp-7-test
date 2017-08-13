using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp7Test
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test()
		{
			var o = Output();
			Console.WriteLine($"{o.Item2} {o.Item1}");
		}

		static (int, string) Output()
		{
			return (7, "Hello from C Sharp ");
		}
	}
}
