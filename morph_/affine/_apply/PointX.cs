using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.affine._apply
{
	/// <summary>
	/// we need to convert the 2-vector to 3-vector before we can multiply it with the affline matrix;
	/// </summary>
	static public class _PointX
	{
		static public double[] Augment(double x, double y) {
			return new double[] { x, y ,1};
		}
	}
}
