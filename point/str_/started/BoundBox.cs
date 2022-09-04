using nilnul.geometry.planar.tope_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points_.started
{
	/// <summary>
	/// a rect that is aligned with axis, and the smallest to enclose the points
	/// </summary>
	static public class _BoundBoxX
	{
		static public planar.Grad _GetBoundingBox(IEnumerable<nilnul.geometry.planar.Point1> _points_started)
		{

			var minX = nilnul.num.real.aggregate_.Min.Eval(_points_started.Select(p => p.x));

			var minY = nilnul.num.real.aggregate_.Min.Eval(_points_started.Select(p => p.y));

			var maxX = nilnul.num.real.aggregate_.Max.Eval(_points_started.Select(p => p.x));

			var maxY = nilnul.num.real.aggregate_.Max.Eval(_points_started.Select(p => p.y));

			return new planar.Grad(
				new Point1(
					minX, minY
				)
				,
				new Point1(maxX, maxY)

			);

		}

		static public nilnul.geometry.planar.tope_.BlocDbl GetBoundingBox(IEnumerable<nilnul.geometry.planar.Point4dbl> _points_started)
		{


			var minX = nilnul.num.real.str_.started._MinX.Min(_points_started.Select(p => p.x));

			var minY = nilnul.num.real.str_.started._MinX.Min(_points_started.Select(p => p.y));

			var maxX = nilnul.num.real.str_.started._MaxX.Max(_points_started.Select(p => p.x));

			var maxY = nilnul.num.real.str_.started._MaxX.Max(_points_started.Select(p => p.y));

			return new BlocDbl(
				new Point4dbl(
					minX, minY
				)
				,
				new _area.SizeDbl(
					maxX-minX
					,
					maxY-minY
				)
			);

		}
	}
}
