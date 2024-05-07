using nilnul.obj;
using System.Collections.Generic;
using System.Drawing;

namespace nilnul.geometry.planar.points_.dwelt
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="Rectangle"/>
	static public class _BoundaryX {

		static public planar.tope_.Bloc4dbl_byBounds _Boundary_0dwelt(IEnumerable<Point4dblI> points) {
			var minX = double.PositiveInfinity;
			var minY = double.PositiveInfinity;
			var maxX = double.NegativeInfinity;
			var maxY = double.NegativeInfinity;

			points.Each(
				p => {
					double x = p.x;

					if (x < minX)
					{
						minX = x;
					}
					if (x > maxX)
					{
						maxX = x;
					}

					double y = p.y;

					if (y < minY)
					{
						minY = y;
					}
					if (y > maxY)
					{
						maxY = y;
					}
				}
			);

			return new tope_.Bloc4dbl_byBounds(minX, maxX, minY, maxY);
		}
	}
}
