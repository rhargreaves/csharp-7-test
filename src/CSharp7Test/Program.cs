using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Test
{
	class Program
	{
		static void Main(string[] args)
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
