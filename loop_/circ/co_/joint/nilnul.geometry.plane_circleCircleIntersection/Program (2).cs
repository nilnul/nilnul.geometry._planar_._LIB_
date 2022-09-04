using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.plane
{
	class Program
	{
		static void Main(string[] args)
		{

			//System.Diagnostics.Debug.WriteLine(HeronFormula.Area(13,12,1));
			System.Diagnostics.Debug.WriteLine(
			Disc.Area(Math.Sqrt(5))-	CircleIntersection.Area(Math.Sqrt(20),Math.Sqrt(5),Math.Sqrt(10))
			);
			
		}
	}
}
