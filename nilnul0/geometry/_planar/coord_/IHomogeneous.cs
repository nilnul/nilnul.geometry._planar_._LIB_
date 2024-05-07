using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry._planar.coord_
{
	///en.wikipedia.org/wiki/Coordinate_system
	/// <summary>
	/// A point in the plane may be represented in homogeneous coordinates by a triple (x, y, z) where x/z and y/z are the Cartesian coordinates of the point. This introduces an "extra" coordinate since only two are needed to specify a point on the plane, but this system is useful in that it represents any point on the projective plane without the use of infinity. In general, a homogeneous coordinate system is one where only the ratios of the coordinates are significant and not the actual values.
	/// </summary>
	public interface IHomogeneous
	{
	}
}
