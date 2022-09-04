using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_
{
	/// <summary>
	/// to homogeneous coordinates, which is a mapping of planar to a 3d flat at z=0.
	/// </summary>
	static public class _HomogeneousX
	{
		static public (double, double, double) ToHomogeneous(double x, double y) {
			return (x, y, 1);
		}
		static public (double, double, double) ToHomogeneous(this (double x, double y) point) {
			return ToHomogeneous (point.x, point. y);
		}

	}
}
