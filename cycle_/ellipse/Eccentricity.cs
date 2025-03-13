using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.ellipse
{
	internal class _EccentricityX
	{
		static public double Eccentricity(
			double longRadius
			,
			double shortRadius
		) {
			return Math.Sqrt(longRadius * longRadius - shortRadius * shortRadius) / longRadius;
		}
	}
}
