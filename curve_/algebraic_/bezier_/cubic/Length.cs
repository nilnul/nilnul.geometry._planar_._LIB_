using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic
{
	/// <summary>
	/// 
	/// </summary>
	static public class _LengthX
	{
		static public double _Length_assumeFlattened(GraphicsPath bezierCubic) {
			var points = bezierCubic.PathPoints;

			//var r = 0d;

			var pairEnum =new nilnul.obj.co.str.of_._PeekAhead_ovStr<PointF>(
				bezierCubic.PathPoints
			);

			return pairEnum.Select(
				p=> nilnul.geometry.planar.tend._DistanceX.Distance(
					p.Item1
					,
					p.Item2
				)
			).Sum();
		}

		static public double Length(GraphicsPath bezierCubic) {

			bezierCubic.Flatten();
			return _Length_assumeFlattened(bezierCubic);


		}

	}
}
