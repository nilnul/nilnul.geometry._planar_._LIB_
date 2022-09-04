using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.polar.co.to_.scalar_
{
	static public class _CrossProductX
	{

		static public double CrossProduct(
			vect_.Polar4dbl a
			,
			vect_.Polar4dbl b
		) {
			///this calculate the parallelogram (or double the triangle)'s area.
			return a.polarPoint.radius * b.polarPoint.radius * Math.Sin(
				b.polarPoint.azimuth-a.polarPoint.azimuth
			);
		}
	}
}
