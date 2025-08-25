using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(new MeterExpr(1.7m).toFootInchFloat());
			Console.WriteLine(new MeterExpr(1.55m).toFootInchFloat());
			Console.WriteLine(new MeterExpr(1.75m).toFootInchFloat());
			
		}
	}
}
