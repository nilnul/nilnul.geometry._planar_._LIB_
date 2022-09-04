using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.vsPoint
{
	/// <summary>
	/// find a point in grad that is the nearest to the given point.
	/// </summary>
	static public class _NearestMemberX
	{
		static public Point4dblI Nearest(
			Grad4dbl_byPointsI grad
			,
			Point4dblI point
		) {

			///find the perpendicular foot.
			var foot = line0point.vsPoint._Foot4perpendX.Foot4perpend( point, grad);

			var footPosition = planar.grad.vsPoint_.colinear.categorize_._Inside4dblX._Categorize(grad, foot);

			switch (footPosition)
			{
				case linear.vect.co.categorize_._inside.Category.Left:
					return grad.basis;
					break;
				case linear.vect.co.categorize_._inside.Category.AtLeftEnd:
					return grad.basis;
					break;
				case linear.vect.co.categorize_._inside.Category.InBetween:
					return foot;
					break;
				case linear.vect.co.categorize_._inside.Category.AtBothEnd:
					return foot;
					break;
				case linear.vect.co.categorize_._inside.Category.AtRightEnd:
					return grad.finish;
					break;
				case linear.vect.co.categorize_._inside.Category.Right:
					return grad.finish;
					break;
				default:
					break;
			}
			throw new UnexpectedReachException();


		}
	}
}
