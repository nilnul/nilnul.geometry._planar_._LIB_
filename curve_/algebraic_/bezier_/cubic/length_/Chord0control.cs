using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic.length_
{
	/*An approximate length of a 3D cubic Bezier curve is the average of its chord length and the sum of the lengths of its control net sides. This approximated average converges on the true arc length very quickly as the parametric domain is reduced.

In English: the chord length is the length of the line segment between the arc endpoints. The control net is the three line segments that define the cubic Bezier. The sum of the lengths of those three line segments, added to the chord length, and divided by two, gives a good approximation to true cubic Bezier arc length.

To get a better approximation, split the cubic Bezier into several smaller cubic Beziers, and perform the operation I described above on each of them, and sum their lengths for the arc length of the entire cubic Bezier.*/

	/// <summary>
	/// chord and Hull
	/// </summary>
	static public class _Chord0controlX
	{

		static public double Dbl(nilnul.geometry.planar.point.Quo4dbl points)
		{
			var chord = (points.d.ToOrthogonal() - points.a).distanceFroOrigin();

			var cont_net =(points.a.ToOrthogonal() - points.b).distanceFroOrigin()
				+ (points.b.ToOrthogonal() - points.c.ToOrthogonal()).distanceFroOrigin()
				+ (points.c - points.d.ToOrthogonal()).distanceFroOrigin();

			return (cont_net + chord) / 2;

		}
	}
}
